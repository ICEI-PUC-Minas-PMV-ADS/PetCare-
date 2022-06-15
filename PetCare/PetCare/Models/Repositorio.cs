using MySqlConnector;
using System.Linq;

namespace PetCare.Models
{
    public class Repositorio
    {
        /*
        user:bda983acb9bb6e
        pass: 4148f624
        host: us-cdbr-east-05.cleardb.net
        banco: heroku_cd40deb8c8e7a90
         */

        //private const string enderecoConexao = "Database=petcare; Datasource=petcarebrasil.mysql.database.azure.com; Username=Bruno@petcarebrasil; Password=Administrador123;";
       private const string enderecoConexao = "Database=heroku_cd40deb8c8e7a90; Datasource=us-cdbr-east-05.cleardb.net; Username=bda983acb9bb6e; Password=4148f624; SSL Mode=None";
        //private const string enderecoConexao = "Database=heroku_cd40deb8c8e7a90; Datasource=localhost; Username=root; Password=admin;";

        //Sistema de Login
        public Usuario Login(Usuario user)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlString = "SELECT * FROM heroku_cd40deb8c8e7a90.usuarios WHERE email = @email AND senha = @senha";

            MySqlCommand comando = new MySqlCommand(sqlString, conexao);
            comando.Parameters.AddWithValue("@email", user.email);
            comando.Parameters.AddWithValue("@senha", user.senha);

            MySqlDataReader dados = comando.ExecuteReader();

            Usuario userLogado = null;

            if (dados.Read())
            {
                userLogado = new Usuario();
                userLogado.id = dados.GetInt32("id");

                if (!dados.IsDBNull(dados.GetOrdinal("nome")))
                {
                    userLogado.nome = dados.GetString("nome");
                }
                if (!dados.IsDBNull(dados.GetOrdinal("email")))
                {
                    userLogado.email = dados.GetString("email");
                }
                if (!dados.IsDBNull(dados.GetOrdinal("senha")))
                {
                    userLogado.senha = dados.GetString("senha");
                }
                if (!dados.IsDBNull(dados.GetOrdinal("nascimento")))
                {
                    userLogado.nascimento = dados.GetString("nascimento");
                }
                if (!dados.IsDBNull(dados.GetOrdinal("imagem")))
                {
                    userLogado.imagem = dados.GetString("imagem");
                }

            }
            conexao.Close();
            return userLogado;
        }

        //CRUD Usuários 
        public void inserirUsuario(Usuario user)
        {
            Console.WriteLine(user.id); 
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "INSERT INTO usuarios(nome,email,senha,nascimento) values(@nome, @email, @senha, @nascimento)";
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);
            cmd.Parameters.AddWithValue("@nome", user.nome);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@senha", user.senha);
            cmd.Parameters.AddWithValue("@nascimento", user.nascimento);
            cmd.ExecuteNonQuery();
            conexao.Close();
        }
        public void ExcluirUsuario(int id)
        {

            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "DELETE FROM usuarios WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conexao.Close();
        }
        public Usuario AlterarUsuario(Usuario user)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "UPDATE usuarios SET nome=@nome,email=@email,senha=@senha,nascimento=@nascimento, imagem=@imagem WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);
            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@nome", user.nome);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@senha", user.senha);
            cmd.Parameters.AddWithValue("@nascimento", user.nascimento);
            cmd.Parameters.AddWithValue("@imagem", user.imagem);

            cmd.ExecuteNonQuery();
            conexao.Close();
            return user;
        }
        public Usuario RetornaUsuario(int id)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "SELECT * FROM heroku_cd40deb8c8e7a90.usuarios WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dados = cmd.ExecuteReader();
            dados.Read();
            Usuario usuario = new Usuario();
            usuario.id = dados.GetInt32("id");
            if (!dados.IsDBNull(dados.GetOrdinal("nome")))
            {
                usuario.nome = dados.GetString("nome");
            }
            if (!dados.IsDBNull(dados.GetOrdinal("email")))
            {
                usuario.email = dados.GetString("email");
            }
            if (!dados.IsDBNull(dados.GetOrdinal("senha")))
            {
                usuario.senha = dados.GetString("senha");
            }
            if (!dados.IsDBNull(dados.GetOrdinal("nascimento")))
            {
                usuario.nascimento = dados.GetString("nascimento");
            }
            if (!dados.IsDBNull(dados.GetOrdinal("imagem")))
            {
                usuario.imagem = dados.GetString("imagem");
            }
            conexao.Close();

            return usuario;
        }

        //CRUD Pets
        public void inserirPet(Pet pet)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "INSERT INTO pets(nome, especie, raca, nascimento, imagem, idDono) values (@nome, @especie, @raca, @nascimento,@imagem, @idDono)";
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);
            cmd.Parameters.AddWithValue("@nome", pet.nome);
            cmd.Parameters.AddWithValue("@especie", pet.especie);
            cmd.Parameters.AddWithValue("@raca", pet.raca);
            cmd.Parameters.AddWithValue("@nascimento", pet.nascimento);
            cmd.Parameters.AddWithValue("@imagem", pet.imagem);
            cmd.Parameters.AddWithValue("@idDono", pet.idDono);
            cmd.ExecuteNonQuery();
            conexao.Close();
        }
        public List<Pet> listaPets(int idDono)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "SELECT * FROM heroku_cd40deb8c8e7a90.pets WHERE idDono=@id";
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);
            cmd.Parameters.AddWithValue("@id", idDono);
            MySqlDataReader dados = cmd.ExecuteReader();
            List<Pet> lista = new List<Pet>();
            while (dados.Read())
            {
                Pet pet = new Pet();

                pet.id = dados.GetInt32("id");
                if (!dados.IsDBNull(dados.GetOrdinal("nome")))
                {
                    pet.nome = dados.GetString("nome");
                }
                if (!dados.IsDBNull(dados.GetOrdinal("especie")))
                {
                    pet.especie = dados.GetString("especie");
                }
                if (!dados.IsDBNull(dados.GetOrdinal("raca")))
                {
                    pet.raca = dados.GetString("raca");
                }
                if (!dados.IsDBNull(dados.GetOrdinal("nascimento")))
                {
                    pet.nascimento = dados.GetString("nascimento");
                }
                if (!dados.IsDBNull(dados.GetOrdinal("imagem")))
                {
                    pet.imagem = dados.GetString("imagem");
                }
                pet.idDono = dados.GetInt32("idDono");
                lista.Add(pet);
            }

            return lista;
        }
        public void AlterarPet(Pet pet)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "UPDATE pets SET nome=@nome, especie=@especie, raca=@raca, nascimento=@nascimento, imagem=@imagem WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);
            cmd.Parameters.AddWithValue("@id", pet.id);
            cmd.Parameters.AddWithValue("@nome", pet.nome);
            cmd.Parameters.AddWithValue("@especie", pet.especie);
            cmd.Parameters.AddWithValue("@raca", pet.raca);
            cmd.Parameters.AddWithValue("@nascimento", pet.nascimento);
            cmd.Parameters.AddWithValue("@imagem", pet.imagem);
            cmd.ExecuteNonQuery();
            conexao.Close();
        }
        public void ExcluirPet(int id)
        {

            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "DELETE FROM pets WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conexao.Close();
        }
        public Pet RetornaPet(int id)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "SELECT * FROM heroku_cd40deb8c8e7a90.pets WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dados = cmd.ExecuteReader();
            dados.Read();
            Pet pet = new Pet();
            pet.id = dados.GetInt32("id");
            if (!dados.IsDBNull(dados.GetOrdinal("nome")))
            {
                pet.nome = dados.GetString("nome");
            }
            if (!dados.IsDBNull(dados.GetOrdinal("especie")))
            {
                pet.especie = dados.GetString("especie");
            }
            if (!dados.IsDBNull(dados.GetOrdinal("raca")))
            {
                pet.raca = dados.GetString("raca");
            }
            if (!dados.IsDBNull(dados.GetOrdinal("nascimento")))
            {
                pet.nascimento = dados.GetString("nascimento");
            }
            if (!dados.IsDBNull(dados.GetOrdinal("imagem")))
            {
                pet.imagem = dados.GetString("imagem");
            }
            pet.idDono = dados.GetInt32("idDono");
            conexao.Close();

            return pet;
        }

        //CRUD Registros
        public int inserirRegistro(IndexModelView modelo, string tipo)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "INSERT INTO heroku_cd40deb8c8e7a90.registros(idpet, tiporegistro, descricao) values(@idpet, @tiporegistro, @descricao)";
            MySqlCommand cmdInsert = new MySqlCommand(stringSql, conexao);
            cmdInsert.Parameters.AddWithValue("@idpet", modelo.idPet);
            cmdInsert.Parameters.AddWithValue("@tiporegistro", tipo);
            cmdInsert.Parameters.AddWithValue("@descricao", modelo.Registro.descricao);
            cmdInsert.ExecuteNonQuery();
            stringSql = "SELECT LAST_INSERT_ID()";
            MySqlCommand cmdGetLastId = new MySqlCommand(stringSql, conexao);
            MySqlDataReader id = cmdGetLastId.ExecuteReader();
            id.Read();
            int idRegistro = id.GetInt32(0);
            conexao.Close();
            return idRegistro;
        }
        public List<IndexModelView> listarRegistrosPesos(int idPet)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSqlPesos = "SELECT r.id, r.idpet, r.tiporegistro, r.descricao,p.observacao, p.peso, p.dataPesagem FROM heroku_cd40deb8c8e7a90.registros AS r INNER JOIN heroku_cd40deb8c8e7a90.pesos AS p ON p.idregistro = r.id AND r.idpet = @idPet ORDER BY r.id ASC";
            MySqlCommand cmdPesos = new MySqlCommand(stringSqlPesos, conexao);
            cmdPesos.Parameters.AddWithValue("@idPet", idPet);
            MySqlDataReader dadosPeso = cmdPesos.ExecuteReader();

            List<IndexModelView> lista = new List<IndexModelView>();
            while (dadosPeso.Read())
            {
                IndexModelView modelo = new IndexModelView();
                Registro registro = new Registro();
                registro.id = dadosPeso.GetInt32("id");
                modelo.idPet = dadosPeso.GetInt32("idPet");
                if (!dadosPeso.IsDBNull(dadosPeso.GetOrdinal("tiporegistro")))
                {
                    registro.tipoRegistro = dadosPeso.GetString("tiporegistro");
                }
                if (!dadosPeso.IsDBNull(dadosPeso.GetOrdinal("descricao")))
                {
                    registro.descricao = dadosPeso.GetString("descricao");
                }
                modelo.Registro = registro;
                Peso peso = new Peso();
                if (!dadosPeso.IsDBNull(dadosPeso.GetOrdinal("observacao")))
                {
                    peso.observacao = dadosPeso.GetString("observacao");
                }
                if (!dadosPeso.IsDBNull(dadosPeso.GetOrdinal("peso")))
                {
                    peso.peso = dadosPeso.GetDouble("peso");
                }
                if (!dadosPeso.IsDBNull(dadosPeso.GetOrdinal("dataPesagem")))
                {
                    peso.dataPesagem = dadosPeso.GetString("dataPesagem");
                }
                modelo.Peso = peso;

                lista.Add(modelo);
            }

            conexao.Close();

            return lista;
        }
        public List<IndexModelView> listarRegistrosMedicamentos(int idPet)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string stringSqlMed = "SELECT r.id, r.idpet, r.tiporegistro, r.descricao, m.nome, m.aplicacao, m.reaplicacao, m.dosagem FROM heroku_cd40deb8c8e7a90.registros AS r INNER JOIN heroku_cd40deb8c8e7a90.medicamentos AS m ON m.idregistro = r.id AND r.idpet = @idPet ORDER BY r.id ASC";
            MySqlCommand cmdMed = new MySqlCommand(stringSqlMed, conexao);
            cmdMed.Parameters.AddWithValue("@idPet", idPet);
            MySqlDataReader dadosMed = cmdMed.ExecuteReader();

            List<IndexModelView> lista = new List<IndexModelView>();
            while (dadosMed.Read())
            {
                IndexModelView modelo = new IndexModelView();
                Registro registro = new Registro();
                registro.id = dadosMed.GetInt32("id");
                modelo.idPet = dadosMed.GetInt32("idPet");
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("tiporegistro")))
                {
                    registro.tipoRegistro = dadosMed.GetString("tiporegistro");
                }
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("descricao")))
                {
                    registro.descricao = dadosMed.GetString("descricao");
                }
                modelo.Registro = registro;
                Medicamento medicamento = new Medicamento();
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("nome")))
                {
                    medicamento.nome = dadosMed.GetString("nome");
                }
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("aplicacao")))
                {
                    medicamento.aplicacao = dadosMed.GetString("aplicacao");
                }
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("reaplicacao")))
                {
                    medicamento.reaplicacao = dadosMed.GetString("reaplicacao");
                }
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("dosagem")))
                {
                    medicamento.dosagem = dadosMed.GetString("dosagem");
                }
                modelo.Medicamento = medicamento;

                lista.Add(modelo);
            }


            conexao.Close();

            return lista;
        }
        public List<IndexModelView> listarRegistrosVacinas(int idPet)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSqlVac = "SELECT r.id, r.idpet, r.tiporegistro, r.descricao, v.nome, v.aplicacao, v.reaplicacao FROM heroku_cd40deb8c8e7a90.registros AS r INNER JOIN heroku_cd40deb8c8e7a90.vacinas AS v ON v.idregistro = r.id AND r.idpet = @idPet ORDER BY r.id ASC";
            MySqlCommand cmdVac = new MySqlCommand(stringSqlVac, conexao);
            cmdVac.Parameters.AddWithValue("@idPet", idPet);
            MySqlDataReader dadosVac = cmdVac.ExecuteReader();

            List<IndexModelView> lista = new List<IndexModelView>();

            while (dadosVac.Read())
            {
                IndexModelView modelo = new IndexModelView();
                Registro registro = new Registro();
                registro.id = dadosVac.GetInt32("id");
                modelo.idPet = dadosVac.GetInt32("idPet");
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("tiporegistro")))
                {
                    registro.tipoRegistro = dadosVac.GetString("tiporegistro");
                }
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("descricao")))
                {
                    registro.descricao = dadosVac.GetString("descricao");
                }
                modelo.Registro = registro;
                Vacina vacina = new Vacina();
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("nome")))
                {
                    vacina.nome = dadosVac.GetString("nome");
                }
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("aplicacao")))
                {
                    vacina.aplicacao = dadosVac.GetString("aplicacao");
                }
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("reaplicacao")))
                {
                    vacina.reaplicacao = dadosVac.GetString("reaplicacao");
                }

                modelo.Vacina = vacina;

                lista.Add(modelo);
            }


            conexao.Close();

            return lista;
        }

        public List<IndexModelView> listarRegistrosTodosMedicamentos()
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string stringSqlMed = "SELECT r.id, r.idpet, r.tiporegistro, r.descricao, m.nome, m.aplicacao, m.reaplicacao, m.dosagem FROM heroku_cd40deb8c8e7a90.registros AS r INNER JOIN heroku_cd40deb8c8e7a90.medicamentos AS m ON m.idregistro = r.id ORDER BY r.id ASC";
            MySqlCommand cmdMed = new MySqlCommand(stringSqlMed, conexao);
        
            MySqlDataReader dadosMed = cmdMed.ExecuteReader();

            List<IndexModelView> lista = new List<IndexModelView>();
            while (dadosMed.Read())
            {
                IndexModelView modelo = new IndexModelView();
                Registro registro = new Registro();
                registro.id = dadosMed.GetInt32("id");
                modelo.idPet = dadosMed.GetInt32("idPet");
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("tiporegistro")))
                {
                    registro.tipoRegistro = dadosMed.GetString("tiporegistro");
                }
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("descricao")))
                {
                    registro.descricao = dadosMed.GetString("descricao");
                }
                modelo.Registro = registro;
                Medicamento medicamento = new Medicamento();
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("nome")))
                {
                    medicamento.nome = dadosMed.GetString("nome");
                }
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("aplicacao")))
                {
                    medicamento.aplicacao = dadosMed.GetString("aplicacao");
                }
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("reaplicacao")))
                {
                    medicamento.reaplicacao = dadosMed.GetString("reaplicacao");
                }
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("dosagem")))
                {
                    medicamento.dosagem = dadosMed.GetString("dosagem");
                }
                modelo.Medicamento = medicamento;

                lista.Add(modelo);
            }


            conexao.Close();

            return lista;
        }

        public List<IndexModelView> listarRegistrosTodasVacinas()
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSqlVac = "SELECT r.id, r.idpet, r.tiporegistro, r.descricao, v.nome, v.aplicacao, v.reaplicacao FROM heroku_cd40deb8c8e7a90.registros AS r INNER JOIN heroku_cd40deb8c8e7a90.vacinas AS v ON v.idregistro = r.id ORDER BY r.id ASC";
            MySqlCommand cmdVac = new MySqlCommand(stringSqlVac, conexao);
            
            MySqlDataReader dadosVac = cmdVac.ExecuteReader();

            List<IndexModelView> lista = new List<IndexModelView>();

            while (dadosVac.Read())
            {
                IndexModelView modelo = new IndexModelView();
                Registro registro = new Registro();
                registro.id = dadosVac.GetInt32("id");
                modelo.idPet = dadosVac.GetInt32("idPet");
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("tiporegistro")))
                {
                    registro.tipoRegistro = dadosVac.GetString("tiporegistro");
                }
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("descricao")))
                {
                    registro.descricao = dadosVac.GetString("descricao");
                }
                modelo.Registro = registro;
                Vacina vacina = new Vacina();
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("nome")))
                {
                    vacina.nome = dadosVac.GetString("nome");
                }
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("aplicacao")))
                {
                    vacina.aplicacao = dadosVac.GetString("aplicacao");
                }
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("reaplicacao")))
                {
                    vacina.reaplicacao = dadosVac.GetString("reaplicacao");
                }

                modelo.Vacina = vacina;

                lista.Add(modelo);
            }


            conexao.Close();

            return lista;
        }
        public IndexModelView retornaRegistro(int idPet, int idReg, string tipoReg)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            //string stringSql = "SELECT r.id, r.idpet, r.tiporegistro, r.descricao,p.observacao, p.peso, p.dataPesagem FROM petcare.registros AS r INNER JOIN petcare.pesos AS p ON p.idregistro = r.id AND r.idpet = @idPet AND r.id=@idReg";
            string stringSql = "";

            switch (tipoReg)
            {
                case "Peso":
                    stringSql = "SELECT r.id, r.idpet, r.tiporegistro, r.descricao,p.observacao, p.peso, p.dataPesagem FROM heroku_cd40deb8c8e7a90.registros AS r INNER JOIN heroku_cd40deb8c8e7a90.pesos AS p ON p.idregistro = r.id AND r.idpet = @idPet AND r.id=@idReg";
                    break;
                case "Medicamento":
                    stringSql = "SELECT r.id, r.idpet, r.tiporegistro, r.descricao,m.nome, m.aplicacao, m.reaplicacao, m.dosagem FROM heroku_cd40deb8c8e7a90.registros AS r INNER JOIN heroku_cd40deb8c8e7a90.medicamentos AS m ON m.idregistro = r.id AND r.idpet = @idPet AND r.id=@idReg";
                    break;
                case "Vacina":
                    stringSql = "SELECT r.id, r.idpet, r.tiporegistro, r.descricao,v.nome, v.aplicacao, v.reaplicacao FROM heroku_cd40deb8c8e7a90.registros AS r INNER JOIN heroku_cd40deb8c8e7a90.vacinas AS v ON v.idregistro = r.id AND r.idpet = @idPet AND r.id=@idReg";
                    break;
            }
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);
            cmd.Parameters.AddWithValue("@idPet", idPet);
            cmd.Parameters.AddWithValue("@idReg", idReg);

            MySqlDataReader dados = cmd.ExecuteReader();
            dados.Read();

            IndexModelView modelo = new IndexModelView();
            Registro registro = new Registro();
            registro.id = dados.GetInt32("id");
            modelo.idPet = dados.GetInt32("idPet");
            if (!dados.IsDBNull(dados.GetOrdinal("tiporegistro")))
            {
                registro.tipoRegistro = dados.GetString("tiporegistro");
            }
            if (!dados.IsDBNull(dados.GetOrdinal("descricao")))
            {
                registro.descricao = dados.GetString("descricao");
            }
            modelo.Registro = registro;

            switch (tipoReg)
            {
                case "Peso":
                    Peso peso = new Peso();
                    if (!dados.IsDBNull(dados.GetOrdinal("observacao")))
                    {
                        peso.observacao = dados.GetString("observacao");
                    }
                    if (!dados.IsDBNull(dados.GetOrdinal("peso")))
                    {
                        peso.peso = dados.GetDouble("peso");
                    }
                    if (!dados.IsDBNull(dados.GetOrdinal("dataPesagem")))
                    {
                        peso.dataPesagem = dados.GetString("dataPesagem");
                    }
                    modelo.Peso = peso;
                    break;
                case "Medicamento":
                    Medicamento medicamento = new Medicamento();
                    if (!dados.IsDBNull(dados.GetOrdinal("nome")))
                    {
                        medicamento.nome = dados.GetString("nome");
                    }
                    if (!dados.IsDBNull(dados.GetOrdinal("aplicacao")))
                    {
                        medicamento.aplicacao = dados.GetString("aplicacao");
                    }
                    if (!dados.IsDBNull(dados.GetOrdinal("reaplicacao")))
                    {
                        medicamento.reaplicacao = dados.GetString("reaplicacao");
                    }
                    if (!dados.IsDBNull(dados.GetOrdinal("dosagem")))
                    {
                        medicamento.dosagem = dados.GetString("dosagem");
                    }
                    modelo.Medicamento = medicamento;
                    break;
                case "Vacina":
                    Vacina vacina = new Vacina();
                    if (!dados.IsDBNull(dados.GetOrdinal("nome")))
                    {
                        vacina.nome = dados.GetString("nome");
                    }
                    if (!dados.IsDBNull(dados.GetOrdinal("aplicacao")))
                    {
                        vacina.aplicacao = dados.GetString("aplicacao");
                    }
                    if (!dados.IsDBNull(dados.GetOrdinal("reaplicacao")))
                    {
                        vacina.reaplicacao = dados.GetString("reaplicacao");
                    }

                    modelo.Vacina = vacina;
                    break;
            }


            conexao.Close();

            return modelo;
        }
        public List<IndexModelView> retornaCalendarioIndividual(int idPet) {
            List<IndexModelView> listaFinal = listarRegistrosMedicamentos(idPet);
            List <IndexModelView> listaVacinas = listarRegistrosVacinas(idPet);
            listaFinal.AddRange(listaVacinas);
            return listaFinal;
        }
        public List<IndexModelView> retornaCalendarioGeral()
        {
            List<IndexModelView> listaFinal = listarRegistrosTodosMedicamentos();
            List<IndexModelView> listaVacinas = listarRegistrosTodasVacinas();
            listaFinal.AddRange(listaVacinas);
            return listaFinal;
        }



        //CRUD Pesos
        public void inserirPeso(IndexModelView peso)
        {
            int idReg = inserirRegistro(peso, "Peso");
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "INSERT INTO heroku_cd40deb8c8e7a90.pesos(idregistro, observacao, peso, dataPesagem) values(@idreg, @observacao, @peso, @data)";
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);

            cmd.Parameters.AddWithValue("@idreg", idReg);
            cmd.Parameters.AddWithValue("@observacao", peso.Peso.observacao);
            cmd.Parameters.AddWithValue("@peso", peso.Peso.peso);
            cmd.Parameters.AddWithValue("@data", peso.Peso.dataPesagem);
            cmd.ExecuteNonQuery();

            conexao.Close();
        }
        public void excluirPeso(int id)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql1 = "DELETE FROM heroku_cd40deb8c8e7a90.pesos WHERE idregistro = @id";
            MySqlCommand cmd = new MySqlCommand(stringSql1, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            string stringSql2 = "DELETE FROM heroku_cd40deb8c8e7a90.registros WHERE id = @id";
            MySqlCommand cmdDelReg = new MySqlCommand(stringSql2, conexao);
            cmdDelReg.Parameters.AddWithValue("@id", id);
            cmdDelReg.ExecuteNonQuery();
            conexao.Close();
        }
        public void AlterarPeso(IndexModelView modelo)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql1 = "UPDATE heroku_cd40deb8c8e7a90.pesos SET observacao=@observacao,peso=@peso,dataPesagem=@dataPesagem WHERE idRegistro=@id";
            MySqlCommand cmdUpdatePeso = new MySqlCommand(stringSql1, conexao);
            cmdUpdatePeso.Parameters.AddWithValue("@id", modelo.Registro.id);
            cmdUpdatePeso.Parameters.AddWithValue("@observacao", modelo.Peso.observacao);
            cmdUpdatePeso.Parameters.AddWithValue("@peso", modelo.Peso.peso);
            cmdUpdatePeso.Parameters.AddWithValue("@dataPesagem", modelo.Peso.dataPesagem);
            cmdUpdatePeso.ExecuteNonQuery();
            string stringSql2 = "UPDATE heroku_cd40deb8c8e7a90.registros SET descricao=@descricao WHERE id=@id";
            MySqlCommand cmdUpdateRegistro = new MySqlCommand(stringSql2, conexao);
            cmdUpdateRegistro.Parameters.AddWithValue("@id", modelo.Registro.id);
            cmdUpdateRegistro.Parameters.AddWithValue("@descricao", modelo.Registro.descricao);
            cmdUpdateRegistro.ExecuteNonQuery();

            conexao.Close();
        }

        //CRUD Medicamentos
        public void inserirMedicamento(IndexModelView medicamento)
        {
            int idReg = inserirRegistro(medicamento, "Medicamento");
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "INSERT INTO heroku_cd40deb8c8e7a90.medicamentos(idregistro, nome, aplicacao, reaplicacao, dosagem) values(@idregistro, @nome, @aplicacao, @reaplicacao, @dosagem)";
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);

            cmd.Parameters.AddWithValue("@idregistro", idReg);
            cmd.Parameters.AddWithValue("@nome", medicamento.Medicamento.nome);
            cmd.Parameters.AddWithValue("@aplicacao", medicamento.Medicamento.aplicacao);
            cmd.Parameters.AddWithValue("@reaplicacao", medicamento.Medicamento.reaplicacao);
            cmd.Parameters.AddWithValue("@dosagem", medicamento.Medicamento.dosagem);

            cmd.ExecuteNonQuery();

            conexao.Close();
        }
        public void excluirMedicamento(int id)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql1 = "DELETE FROM heroku_cd40deb8c8e7a90.medicamentos WHERE idregistro = @id";
            MySqlCommand cmd = new MySqlCommand(stringSql1, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            string stringSql2 = "DELETE FROM heroku_cd40deb8c8e7a90.registros WHERE id = @id";
            MySqlCommand cmdDelReg = new MySqlCommand(stringSql2, conexao);
            cmdDelReg.Parameters.AddWithValue("@id", id);
            cmdDelReg.ExecuteNonQuery();
            conexao.Close();
        }
        public void AlterarMedicamento(IndexModelView modelo)
        {
            Console.WriteLine(modelo.Medicamento.dosagem);
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql1 = "UPDATE heroku_cd40deb8c8e7a90.medicamentos SET nome=@nome, aplicacao=@aplicacao, reaplicacao=@reaplicacao, dosagem=@dosagem WHERE idRegistro=@id";
            MySqlCommand cmdUpdatePeso = new MySqlCommand(stringSql1, conexao);
            cmdUpdatePeso.Parameters.AddWithValue("@id", modelo.Registro.id);
            cmdUpdatePeso.Parameters.AddWithValue("@nome", modelo.Medicamento.nome);
            cmdUpdatePeso.Parameters.AddWithValue("@aplicacao", modelo.Medicamento.aplicacao);
            cmdUpdatePeso.Parameters.AddWithValue("@reaplicacao", modelo.Medicamento.reaplicacao);
            cmdUpdatePeso.Parameters.AddWithValue("@dosagem", modelo.Medicamento.dosagem);
            cmdUpdatePeso.ExecuteNonQuery();
            string stringSql2 = "UPDATE heroku_cd40deb8c8e7a90.registros SET descricao=@descricao WHERE id=@id";
            MySqlCommand cmdUpdateRegistro = new MySqlCommand(stringSql2, conexao);
            cmdUpdateRegistro.Parameters.AddWithValue("@id", modelo.Registro.id);
            cmdUpdateRegistro.Parameters.AddWithValue("@descricao", modelo.Registro.descricao);
            cmdUpdateRegistro.ExecuteNonQuery();

            conexao.Close();
        }


        //CRUD Vacinas
        public void inserirVacina(IndexModelView vacina)
        {
            int idReg = inserirRegistro(vacina, "Vacina");
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql = "INSERT INTO heroku_cd40deb8c8e7a90.vacinas(idregistro, nome, aplicacao, reaplicacao) values(@idregistro, @nome, @aplicacao, @reaplicacao)";
            MySqlCommand cmd = new MySqlCommand(stringSql, conexao);

            cmd.Parameters.AddWithValue("@idregistro", idReg);
            cmd.Parameters.AddWithValue("@nome", vacina.Medicamento.nome);
            cmd.Parameters.AddWithValue("@aplicacao", vacina.Medicamento.aplicacao);
            cmd.Parameters.AddWithValue("@reaplicacao", vacina.Medicamento.reaplicacao);


            cmd.ExecuteNonQuery();

            conexao.Close();
        }

        public void AlterarVacina(IndexModelView modelo)
        {
            Console.WriteLine(modelo.Medicamento.dosagem);
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql1 = "UPDATE heroku_cd40deb8c8e7a90.vacinas SET nome=@nome, aplicacao=@aplicacao, reaplicacao=@reaplicacao WHERE idRegistro=@id";
            MySqlCommand cmdUpdatePeso = new MySqlCommand(stringSql1, conexao);
            cmdUpdatePeso.Parameters.AddWithValue("@id", modelo.Registro.id);
            cmdUpdatePeso.Parameters.AddWithValue("@nome", modelo.Medicamento.nome);
            cmdUpdatePeso.Parameters.AddWithValue("@aplicacao", modelo.Medicamento.aplicacao);
            cmdUpdatePeso.Parameters.AddWithValue("@reaplicacao", modelo.Medicamento.reaplicacao);
            cmdUpdatePeso.ExecuteNonQuery();
            string stringSql2 = "UPDATE heroku_cd40deb8c8e7a90.registros SET descricao=@descricao WHERE id=@id";
            MySqlCommand cmdUpdateRegistro = new MySqlCommand(stringSql2, conexao);
            cmdUpdateRegistro.Parameters.AddWithValue("@id", modelo.Registro.id);
            cmdUpdateRegistro.Parameters.AddWithValue("@descricao", modelo.Registro.descricao);
            cmdUpdateRegistro.ExecuteNonQuery();

            conexao.Close();
        }

        public void excluirVacina(int id)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringSql1 = "DELETE FROM heroku_cd40deb8c8e7a90.medicamentos WHERE idregistro = @id";
            MySqlCommand cmd = new MySqlCommand(stringSql1, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            string stringSql2 = "DELETE FROM heroku_cd40deb8c8e7a90.registros WHERE id = @id";
            MySqlCommand cmdDelReg = new MySqlCommand(stringSql2, conexao);
            cmdDelReg.Parameters.AddWithValue("@id", id);
            cmdDelReg.ExecuteNonQuery();
            conexao.Close();
        }

        //Busca de medicamento ou vacina
        public List<IndexModelView> buscarMedicamento(string textBuscado)
        {
            
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringsql = "SELECT r.id, r.idpet, r.tiporegistro, r.descricao, m.nome, m.aplicacao, m.reaplicacao, m.dosagem FROM heroku_cd40deb8c8e7a90.registros AS r inner JOIN heroku_cd40deb8c8e7a90.medicamentos AS m ON m.idRegistro=r.id and m.nome LIKE @textBuscado";
            MySqlCommand cmd = new MySqlCommand(stringsql, conexao);
            cmd.Parameters.AddWithValue("@textBuscado", "%" + textBuscado + "%");
            Console.WriteLine(cmd);
            MySqlDataReader dadosMed = cmd.ExecuteReader();

            List<IndexModelView> lista = new List<IndexModelView>();
            while (dadosMed.Read())
            {
                IndexModelView modelo = new IndexModelView();
                Registro registro = new Registro();
                registro.id = dadosMed.GetInt32("id");
                modelo.idPet = dadosMed.GetInt32("idPet");
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("tiporegistro")))
                {
                    registro.tipoRegistro = dadosMed.GetString("tiporegistro");
                }
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("descricao")))
                {
                    registro.descricao = dadosMed.GetString("descricao");
                }
                modelo.Registro = registro;
                Medicamento medicamento = new Medicamento();
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("nome")))
                {
                    medicamento.nome = dadosMed.GetString("nome");
                }
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("aplicacao")))
                {
                    medicamento.aplicacao = dadosMed.GetString("aplicacao");
                }
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("reaplicacao")))
                {
                    medicamento.reaplicacao = dadosMed.GetString("reaplicacao");
                }
                if (!dadosMed.IsDBNull(dadosMed.GetOrdinal("dosagem")))
                {
                    medicamento.dosagem = dadosMed.GetString("dosagem");
                }
                modelo.Medicamento = medicamento;
                Console.WriteLine(modelo.Medicamento.nome);
                lista.Add(modelo);
            }

            return lista;
        }

        public List<IndexModelView> buscarVacina(string textBuscado)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            string stringsql = "SELECT r.id, r.idpet, r.tiporegistro, r.descricao, v.nome, v.aplicacao, v.reaplicacao FROM heroku_cd40deb8c8e7a90.registros AS r inner JOIN heroku_cd40deb8c8e7a90.vacinas AS v ON v.idRegistro=r.id and v.nome LIKE @textBuscado";
            MySqlCommand cmd = new MySqlCommand(stringsql, conexao);
            cmd.Parameters.AddWithValue("@textBuscado", "%"+ textBuscado+"%");
            MySqlDataReader dadosVac = cmd.ExecuteReader();
            List<IndexModelView> lista = new List<IndexModelView>();

            while (dadosVac.Read())
            {
                IndexModelView modelo = new IndexModelView();
                Registro registro = new Registro();
                registro.id = dadosVac.GetInt32("id");
                modelo.idPet = dadosVac.GetInt32("idPet");
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("tiporegistro")))
                {
                    registro.tipoRegistro = dadosVac.GetString("tiporegistro");
                }
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("descricao")))
                {
                    registro.descricao = dadosVac.GetString("descricao");
                }
                modelo.Registro = registro;
                Vacina vacina = new Vacina();
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("nome")))
                {
                    vacina.nome = dadosVac.GetString("nome");
                }
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("aplicacao")))
                {
                    vacina.aplicacao = dadosVac.GetString("aplicacao");
                }
                if (!dadosVac.IsDBNull(dadosVac.GetOrdinal("reaplicacao")))
                {
                    vacina.reaplicacao = dadosVac.GetString("reaplicacao");
                }

                modelo.Vacina = vacina;
                Console.WriteLine(modelo.Vacina.nome);

                lista.Add(modelo);
            }
            return lista;
        }

        public List<IndexModelView> buscaFinal(string textBuscado)
        {
            List<IndexModelView> lista= buscarMedicamento(textBuscado);
            List<IndexModelView> listaVacinasBuscado = buscarVacina(textBuscado);
            lista.AddRange(listaVacinasBuscado);
            return lista;
        }

    }

}
