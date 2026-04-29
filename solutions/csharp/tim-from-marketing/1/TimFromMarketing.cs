static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idPart = id == null ? "" : $"[{id}] - ";
        string departmentPart = department ?? "OWNER";
        
        return $"{idPart}{name} - {departmentPart.ToUpper()}";
    }
}
