using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace tienda
{
    class conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;
        public conexion()
        {
            try
            {
                //cn = new SqlConnection("Data Source=LAPTOP-54JO58E1;Initial Catalog=Tienda;Integrated Security=True");
                cn = new SqlConnection("	workstation id=prueba19.mssql.somee.com;packet size=4096;user id=cesarvi_SQLLogin_1;pwd=nugotghy5e;data source=prueba19.mssql.somee.com;persist security info=False;initial catalog=prueba19");
                cn.Open();
            
                

            }catch(Exception e)
            {
                MessageBox.Show("NO CONECTADO; ERROR " + e);
            }
        }

        public string insertar  (int id,string producto,string cantidad)
        {
            string msn = "Insertado correctamente";
            try
            {
                cmd = new SqlCommand("insert into productos(Id,Producto,Cantidad)values(" + id + ",'" + producto + "','"+cantidad+"')",cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                msn = "NO SE EJECUTO " + e.Message;
            }
            return msn;
        }
        
        public string eliminar(int id)
        {
            string msn = "Eliminado correctamente";
            try
            {
                cmd = new SqlCommand("delete from productos where Id=" + id + "",cn);
                cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                msn = "NO insertado " + e.Message;
            }
            return msn;
        }
        public int verificar(int id)
        {
            int contar = 0;
            try
            {
                cmd = new SqlCommand("Select * from productos where Id="+id+"",cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    contar++;
                }
                dr.Close();
            }
            catch (Exception b)
            {
                MessageBox.Show("NO SE PUDO EJECUTAR " +b.Message);
            }
            return contar;
        }

        public void consultarPersona(DataGridView dg)
        {
            try
            {
                da = new SqlDataAdapter("Select * from productos ", cn);
                dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("NO se puedo rellenar el datagirdView " + e.Message);
            }
        }
    }
}
