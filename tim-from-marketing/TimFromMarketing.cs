using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string temp_department = department ?? "OWNER";

        if (id == null)
        {
            return $"{name} - {temp_department.ToUpper()}";
        }
        else
        {
            return $"[{id}] - {name} - {temp_department.ToUpper()}";
        }
    }
}
