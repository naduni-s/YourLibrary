using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Policy;

namespace LibrarySystem.CLASSES
{
    internal class Library
    {
        DATABASE.Mydb db = new DATABASE.Mydb();
        public Boolean addBook(string isbn, string title, string author, string publisher, string genre, string language)
        {
            string query = "INSERT INTO `books`(`isbn`, `title`, `author`, `publisher`, `genre`, `language`) VALUES (@isbn, @title, @author, @publisher, @genre, @language)";
            MySqlParameter[] parameters  = new MySqlParameter[6];

            parameters[0] = new MySqlParameter("@isbn",MySqlDbType.VarChar);
            parameters[0].Value = isbn; 
            parameters[1] = new MySqlParameter("title", MySqlDbType.VarChar);
            parameters[1].Value = title;
            parameters[2] = new MySqlParameter("author", MySqlDbType.VarChar);
            parameters[2].Value = author;
            parameters[3] = new MySqlParameter("publisher", MySqlDbType.VarChar);
            parameters[3].Value = publisher;
            parameters[4] = new MySqlParameter("genre", MySqlDbType.VarChar);
            parameters[4].Value = genre;
            parameters[5] = new MySqlParameter("language", MySqlDbType.VarChar);
            parameters[5].Value = language;

            if(db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean editBook(string isbn, string title, string author, string publisher, string genre, string language)
        {
            string query = "UPDATE `books` SET `title`=@title_new,`author`=@author_new,`publisher`=@publisher_new,`genre`=@genre_new,`language`=@language_new WHERE `isbn`=@isbn";
            MySqlParameter[] parameters = new MySqlParameter[6];

            parameters[0] = new MySqlParameter("title_new", MySqlDbType.VarChar);
            parameters[0].Value = title;
            parameters[1] = new MySqlParameter("author_new", MySqlDbType.VarChar);
            parameters[1].Value = author;
            parameters[2] = new MySqlParameter("publisher_new", MySqlDbType.VarChar);
            parameters[2].Value = publisher;
            parameters[3] = new MySqlParameter("genre_new", MySqlDbType.VarChar);
            parameters[3].Value = genre;
            parameters[4] = new MySqlParameter("language_new", MySqlDbType.VarChar);
            parameters[4].Value = language;
            parameters[5] = new MySqlParameter("isbn", MySqlDbType.VarChar);
            parameters[5].Value = isbn;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean removeBook(string isbn, string title, string author, string publisher, string genre, string language)
        {
            string query = "DELETE FROM `books` WHERE `isbn`= @isbn";
            MySqlParameter[] parameters = new MySqlParameter[1];

            parameters[0] = new MySqlParameter("isbn", MySqlDbType.VarChar);
            parameters[0].Value = isbn;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean isIsbnExists(string isbn)
        {
            DataTable table = new DataTable();
            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameters[0].Value = isbn;
            table = db.getData("SELECT * FROM `books` WHERE `isbn`= @isbn", parameters);
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
        public Boolean isTitleExists(string title)
        {
            DataTable table = new DataTable();
            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@title", MySqlDbType.VarChar);
            parameters[0].Value = title;
            table = db.getData("SELECT * FROM `books` WHERE `title`= @title", parameters);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable BookList()
        {
            DataTable table = new DataTable();
            MySqlParameter[] parameters = new MySqlParameter[0];
            table = db.getData("SELECT * FROM `books`", parameters);
            return table;
        }
        public DataTable searchbookBy_Isbn(string isbn)
        {
            DataTable table = new DataTable();
            if (!string.IsNullOrEmpty(isbn))
            {
                MySqlParameter[] parameters = new MySqlParameter[1];
                parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
                parameters[0].Value = isbn;
                table = db.getData("SELECT * FROM `books` WHERE `isbn`= @isbn", parameters);
            }
            return table;
        }
    }
}

