[ApiController] 
[Route ("api/[controller]")]
public class BibliotecaController : ControllerBase
{
    private readonly IMongoCollection<Biblioteca> _bibliotecaCollection;

    public BibliotecaController(IMongoClient client)
    {
        var database = client.GetDatabase("tiendaDB");
        _bibliotecaCollection = database.GetCollection<Biblioteca>("biblioteca");
    }

    [HttpGet]
    public async Task<IEnumerable<biblioteca>> Get()
    {
        return await _bibliotecaCollection.Find(p => true).ToListAsync();
    }
} 