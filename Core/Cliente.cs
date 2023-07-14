namespace Core
{
    public class Cliente
    {
        public string IdTipoCliente { get; set; } // Natural o juridica
        public string? NombreCompleto { get; set; } = string.Empty;
        public string? RazonSocial { get; set; } = string.Empty;
        public string IdTipoDocumento { get; set; } = string.Empty; // CC o NIT
        public string Documento { get; set; } = string.Empty;
    }
}