using MongoDB.Bson.Serialization.Attributes;

public class ClasificacionMongo {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("Nombre")]
    public string Nombre { get; set; } = string.Empty;

    public int Edad { get; set; }
    public string Escuderia { get; set; } = string.Empty;
    public int Podios { get; set; }
    public int PolePositions { get; set; }
    public int CarrerasGanadas { get; set; }
    public int Temporadas { get; set; }
    public string Nacionalidad { get; set; } = string.Empty;
    public List<string>? Clasificacion { get; set; }
}
