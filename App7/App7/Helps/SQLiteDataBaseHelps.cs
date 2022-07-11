using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using App7.models;
using System.Threading.Tasks;

namespace App7.Helps
{
    public class SQLiteDataBaseHelps
    {
        // Propriedade entre aspas para armazenar no banco de dados 
        readonly SQLiteAsyncConnection _db;

        //Arquivos para chegar ao caminho do banco 

        public SQLiteDataBaseHelps(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);

            //Criaçaõ de tabela em class de modelo

            _db.CreateTableAsync<Atividade>().Wait();

        }


        //GetAllROws() Pegar arquivos em modo decrescente
        public Task<List<Atividade>> GetAllRows()
        {
            return _db.Table<Atividade>().OrderByDescending(i => i.Id).ToListAsync();
        }

        //GetById(int id)// Pegar regiostro em specifico
        public Task<Atividade> GetById(int id)
        {
            return _db.Table<Atividade>().FirstAsync(i => i.Id == id);
        }


        //Insert(Atividade model) inserir no banco
        public Task<int> Insert(Atividade model)
        {
            return _db.InsertAsync(model);
        }

        //Upadate(Atividade model) atualizar no banco
        public Task<List<Atividade>> Update(Atividade model)
        {
            string sql = "UPDATE Atividade SET Descricao=?, Data=?, Peso=?, Observacoes=? WHERE Id=?";

            return _db.QueryAsync<Atividade>( sql, 
                model.Descricao, 
                model.Date, 
                model.Peso, 
                model.Observacoes, 
                model.Id);
        }


        //Delete(int id)  deletar no banco 
        public Task<int> Delete(int id)
        {
            return _db.Table<Atividade>().DeleteAsync(i => i.Id == id);

        }


        //Search(string query) Pesquisando no banco de dados
        public Task<List<Atividade>> Search(string q)
        {
            string sql = "SELECT * FROM Atividade WHERE Dscricao like '%" + q + "%'";
            return _db.QueryAsync<Atividade>(sql);
        }
       


        

    }
}
