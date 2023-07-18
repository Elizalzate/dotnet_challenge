namespace GestionClientesAPI.DTO
{
    public class CreateClientDTO
    {
        public string Documento { get; set; } = String.Empty;
        public int IdTipoDocumento { get; set; } // CC o NIT
        public int IdTipoCliente { get; set; } // Natural o juridica
        public string? NombreCompleto { get; set; } = string.Empty;
        public string? RazonSocial { get; set; } = string.Empty;

    }
}
