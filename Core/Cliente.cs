namespace Core
{
    public class Cliente
    {
        public string TipoCliente { get; set; } // Natural o juridica
        public string? NombreCompleto { get; set; } = string.Empty;
        public string? RazonSocial { get; set; } = string.Empty;
        public string TipoDocumento { get; set; } = string.Empty; // CC o NIT
        public string Documento { get; set; } = string.Empty;
    }
}