namespace GamePlatform.Application.DTOs;

public class ResultadoPaginadoDto<T>
{
    public IEnumerable<T> Itens { get; init; } = [];
    public int NumeroPagina { get; init; }
    public int TamanhoPagina { get; init; }
    public int TotalDeItens { get; init; }
}