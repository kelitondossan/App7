using System;
using SQLite;
namespace App7.models
{
    public class Atividade
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Descricao { get; set; }

        public DateTime Date { get; set; }

        public double? Peso { get; set;}

        public string Observacoes { get; set; }

    }
}
