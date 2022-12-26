using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading){
        var (prefixInt, length) = reading switch
        {
            >= 4_294_967_296 and <= 9_223_372_036_854_775_807 => (256-8, 8),    //long
            >= 2_147_483_648 and <= 4_294_967_295 => (4, 4),	//uint
            >= 65_536 and <= 2_147_483_647 => (256-4, 4),	//int
            >= 0 and <= 65_535 => (2, 2),	//ushort
            >= -32_768 and <= -1 => (256-2, 2),	//short
            >= -2_147_483_648 and <= -32_769 => (256-4, 4),	//int
            >= -9_223_372_036_854_775_808 and <= -2_147_483_649 => (256-8, 8),	//long
        };

        var prefixByte = BitConverter.GetBytes(prefixInt);

        var buffer = new byte[9];

        Array.Copy(prefixByte, 0, buffer, 0, 1);

        var valueByte = BitConverter.GetBytes(reading);

        Array.Copy(valueByte, 0, buffer, 1, length);

        return buffer;
    } 

    public static long FromBuffer(byte[] buffer)
    {
        return buffer[0] switch
        {
            256-8 => BitConverter.ToInt64(buffer[1..9]),    //long
            4 => (long)BitConverter.ToUInt32(buffer[1..5]),	//uint
            256-4 => (long)BitConverter.ToInt32(buffer[1..5]),	//int
            2 => (long)BitConverter.ToUInt16(buffer[1..3]),	//ushort
            256-2 => (long)BitConverter.ToInt16(buffer[1..3]),	//short
            _ => 0 //For an invalid buffer the test expect 0, strange but whatever, throw new NotImplementedException()
        };
    }
}
