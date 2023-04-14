using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{Id=1, Nombre="Vista a la piscina", Ocupantes = 5, MetrosCuadrados=40},
            new VillaDto{Id=2,Nombre = "Vista a la playa", Ocupantes=8, MetrosCuadrados= 60}
        };
    }
}
