using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string formatedId = "";
        if (id != null) formatedId = $"[{id}] - ";

        return $"{formatedId}{name} - {department?.ToUpper() ?? "OWNER"}";
    }
}
