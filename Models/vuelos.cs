using MongoDB.Bson.Serialization.Attribbutes;
public class Aeropuerto{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set;}
    public string pais_origen { get; set;} = string.Empty;
    public string ciudad_origen { get; set;} = string.Empty;
    public string aeropuerto_origen { get; set;} = string.Empty;
     public string pais_destino { get; set;} = string.Empty;
      public string ciudad_destino { get; set;} = string.Empty;
       public string aeropuerto_destino { get; set;} = string.Empty;
        public string tipo_avion { get; set;} = string.Empty;
         public string cupo_avion { get; set;} = string.Empty;
          public string pasajeros_actuales { get; set;} = string.Empty;
           public string fecha_hora_salida { get; set;} = string.Empty;
            public string fecha_hora_llegada_aproximada { get; set;} = string.Empty;
             public string nombre_piloto { get; set;} = string.Empty;
              public string estatus_vuelo { get; set;} = string.Empty;
}  