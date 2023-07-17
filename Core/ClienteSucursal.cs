namespace Core
{
    public class ClienteSucursal
    {
        public required string Documento { get; set; }
        public required string CodigoSucursal { get; set; }

        public Cliente Cliente { get; set; }
        public Sucursal Sucursal { get; set; }
    }
}