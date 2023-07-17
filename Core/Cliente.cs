namespace Core
{
    public class Cliente
    {
        public required string Documento { get; set; }
        public int IdTipoDocumento { get; set; } // CC o NIT
        public int IdTipoCliente { get; set; } // Natural o juridica
        public string? NombreCompleto { get; set; } = string.Empty;
        public string? RazonSocial { get; set; } = string.Empty;

        public ClienteDetalles? ClienteDetalles { get; set; }
        public ICollection<ClienteSucursal> ClienteSucursal { get; set; }
    }
}