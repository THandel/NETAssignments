using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Assignment8.Models;

namespace Assignment8
{
    public class PlayerDataProvider
    {
        string _conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Documents\PlayerDB.mdf;Integrated Security=True;Connect Timeout=30";
        List<int> distArray = new List<int>();
        List<double> spdArray = new List<double>();
        public List<Player> playerList = new List<Player>();
        decimal avgDist = 0;
        double avgSpeed = 0;
        decimal totalDist = 0;
        double totalSpeed = 0;

        public List<Player> DataRead(List<Player> list)
        {
            SqlConnection conn = new SqlConnection(_conString);
            SqlCommand cmd = new SqlCommand("select * from Players", conn);
            SqlDataReader rdr = null;
            playerList.Clear();
            //clear _playerList to prevent new Player objects being added to 
            //the existing list every time DataRead() is called

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Player p = new Player();
                    p.ID = (int)rdr["PlayerID"];
                    p.name = (string)rdr["PlayerName"];
                    p.height = (int)rdr["PlayerHeight"];
                    p.age = (int)rdr["PlayerAge"];
                    p.speed = (double)rdr["RunningSpeed"];
                    p.dist = (int)rdr["RunningDistance"];
                    playerList.Add(p);
                }
                populateLists();
                return playerList;
            }

            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void populateLists()
        {
            foreach (Player p in playerList)
            {
                distArray.Add(p.dist);
                spdArray.Add(p.speed);
            }
        }

        public double averageSpeed()
        {
            try
            {
                foreach (Player p in playerList)
                {
                    totalSpeed += p.speed;
                }
                avgSpeed = Math.Round((totalSpeed / playerList.Count), 2); //get average, rounded to two decimal places
                Console.WriteLine("The average speed of all the players is: {0}", avgSpeed);
                return avgSpeed;
            }
            catch
            {
                throw (new ListEmptyException("List Empty: No items to compare!"));
            }
            finally
            {
                totalSpeed = 0; //set totalSpeed to 0 to avoid a case where the user clicks Refresh repeatedly,
                //causing the speed variables to be added to totalSpeed each time
            }
        }

        public decimal avgDistance()
        {
            try
            {
                foreach (Player p in playerList)
                {
                    totalDist += p.dist;
                }
                avgDist = Math.Round((totalDist / playerList.Count), 2);
                Console.WriteLine("The average distance run by all the players is: {0}m", avgDist);
                return avgDist;
            }
            catch
            {
                throw (new ListEmptyException("List Empty: No items to compare!"));
            }
            finally
            {
                totalDist = 0; //set totalDist to 0 to avoid a case where the user clicks Refresh repeatedly,
                //causing the distance values to be added to totalDist each time
            }
        }

        public double minSpeed()
        {
            try
            {
                double minSpd = spdArray.Min();
                Console.WriteLine("The minimum speed run is: {0}", minSpd);
                return minSpd;
            }
            catch
            {
                throw (new ListEmptyException("List Empty: No items to compare!"));
            }
        }

        public double maxSpeed()
        {
            try
            {
                double maxSpd = spdArray.Max();
                Console.WriteLine("The maximum speed run is: {0}", maxSpd);
                return maxSpd;
            }
            catch
            {
                throw (new ListEmptyException("List Empty: No items to compare!"));
            }
        }

        public int minDist()
        {
            try
            {
                var minDist = distArray.Min();
                Console.WriteLine("The minimum distance run is: {0}m", minDist);
                return minDist;
            }
            catch
            {
                throw (new ListEmptyException("List Empty: No items to compare!"));
            }
        }

        public int maxDist()
        {
            try
            {
                int maxDist = distArray.Max();
                Console.WriteLine("The maximum distance run is: {0}m", maxDist);
                return maxDist;
            }
            catch
            {
                throw (new ListEmptyException("List Empty: No items to compare!"));
            }
        }

        public void InsertData(int newID, string newName, int newAge, int newHeight, int newDist, decimal newSpeed)
        {
            SqlConnection conn = new SqlConnection(_conString);
            string newData = "'" + newID + "', '" + newName + "', '" + newAge + "', '" + newHeight + "', '" + newDist + "', '" + newSpeed + "'";
            string insertString = @"insert into Players(PlayerID, PlayerName, PlayerAge, PlayerHeight, RunningDistance, RunningSpeed)values (" + newData + ")";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw (new PlayerExistsException("A player with this ID already exists!"));
                //throw an exception if a player with this ID is already present in the database
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void DataUpdate(int updateID, string newName, int newAge, int newHeight, double newSpd, int newDist)
        {

            SqlConnection conn = new SqlConnection(_conString);
            string updateString = @"update Players SET PlayerName = '" + newName + "', PlayerHeight = '"+newHeight+
                "', PlayerAge = '" + newAge + "', RunningDistance = '"+ newDist+"', RunningSpeed = '"+newSpd+
                 "' WHERE PlayerID = '" + updateID + "';";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(updateString, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw (new NoPlayerException("No player with this ID exists!"));
                //throw an exception if there is no player matching the ID provided
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void DataDelete(int delID)
        {
            SqlConnection conn = new SqlConnection(_conString);
            string deleteString = @"delete from Players where PlayerID = '" + delID + "'";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw (new NoPlayerException("No player with this ID exists!"));
                //throw an exception if there is no player matching the ID provided
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
