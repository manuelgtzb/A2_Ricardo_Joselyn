using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("conexion")]
public class Conexion : Controller {
    // Método para listar desde MongoDB
    [HttpGet("mongo")]
    public IActionResult ListarSalonesMongoDb() {
        // Conexión a MongoDB
        MongoClient client = new MongoClient(CadenasConexionX.MONGO_DB);
        var db = client.GetDatabase("Practica2_Ricardo_Joselyn");
        var collection = db.GetCollection<ClasificacionMongo>("ClasificacionPilotos");

        // Obtener todos los documentos de la colección
        var lista = collection.Find(FilterDefinition<ClasificacionMongo>.Empty).ToList();

        return Ok(lista); // Retorna la lista de pilotos en formato JSON
    }
}
