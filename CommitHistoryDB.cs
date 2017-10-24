using MySql.Data.MySqlClient;

namespace bitb_reposhow_c {

    class DB {

        public void start() {

        }

        MySqlConnection open() {
            var result = new MySqlConnection();
            result.ConnectionString = "";
            result.Open();
            return result;
        }

    }

}