using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public int SelectUserEmail(string email, int Password)
        {
            string query = "SELECT COUNT(*) FROM USERR WHERE Email ='" + email + "' AND Password= '" + Password + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable SelectWarnings(string email)
        {
            string query = "SELECT Warn_Type FROM Warns,USERR,Passenger WHERE Passenger_NationalID=USERR_NationalID AND Email ='" + email + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectReservedTrips(string email)
        {
            string query = "SELECT Trip.TripID,Source,Destination,Trip_Date,Trains_IN_Service.Train_ID FROM Trip,Ticket,Trains_IN_Service WHERE Trains_IN_Service.Trip_ID=TripID AND OnlineCustomer_Email ='" + email + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectNewsAndUpdates()
        {
            string query = "SELECT News_Updates FROM Manager ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectUserAccountInfo(string email)
        {
            string query = "SELECT * FROM USERR WHERE  Email ='" + email + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectTripsTimeTable(string DepartureSelect, string ArrivalSelect, string TravelDate)
        {
            string query = "SELECT Trip.TripID,Source,Destination,Trip_Date,Trains_IN_Service.Train_ID FROM Trip,Trains_IN_Service WHERE Source='" + DepartureSelect + "' AND Destination= '" + ArrivalSelect + "' AND Trip_Date= '" + TravelDate + "';";
            return dbMan.ExecuteReader(query);
        }
        public int SelectAvailableTripsTimeTable(string DepartureSelect, string ArrivalSelect, string TravelDate, int seatnum, int tripid)
        {
            string query = "SELECT count(TicketSeat) FROM Tickets,Trip WHERE TicketTrip_ID==Trip_ID AND TripSource='" + DepartureSelect + "' AND TripDestination= '" + ArrivalSelect + "' AND TripDate= '" + TravelDate + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int InsertTicket(int TrainID, int CoachID, string Ticketsrc, string TicketDist, int TripID, int seatnum, int CusID)
        {
            string query = "INSERT INTO Tickets (Train_ID_OfTicket,Coach_ID_OfTicket,Ticket_Source, Ticket_Destination,TicketTrip_ID,TicketSeat,OnlineCustomer_ID) " +
                             "Values ('" + TrainID + "', '" + CoachID + "','" + Ticketsrc + "','" + TicketDist + "','" + TripID + "','" + seatnum + "','" + CusID + "');";

            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertUserEmail(int ID, string Fname, string LName, string Email, int password, string Date, string sex)
        {
            string query = "INSERT INTO USERR (USERR_ID,USERR_FName,USERR_LName, Email,Password,Birth_Of_Date,Sex) " +
                             "Values ('" + ID + "', '" + Fname + "','" + LName + "','" + Email + "','" + password + "','" + Date + "','" + sex + "');";

            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable CheckWhetherCustomerViewOrNot(string email)
        {
            string query = "SELECT COUNT(OnlineCustomer_Email) FROM OnlineCustomer WHERE OnlineCustomer_Email='" + email + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable CheckWhetherTicketOfficeViewOrNot(string email)
        {
            string query = "SELECT COUNT(Ticket_Office_Email) FROM TicketOfficeWorker WHERE Ticket_Office_Email='" + email + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable CheckWhetherManagerOrNot(string email)
        {
            string query = "SELECT COUNT(Manager_Email) FROM Manager WHERE Manager_Email='" + email + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable CheckWhetherServiceWorkerOrNot(string email)
        {
            string query = "SELECT COUNT(MaintenanceWorker_Email) FROM MaintenanceWorker WHERE MaintenanceWorker_Email='" + email + "';";
            return dbMan.ExecuteReader(query);
        }

        public int DeleteTicket(string email)
        {
            string query = "DELETE FROM Tickets WHERE Email ='" + email + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteAccount(string email)
        {
            string query = "DELETE FROM USERR WHERE Email ='" + email + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateUserFname(string email, string Fname)
        {
            string query = "UPDATE USERR SET USERR_FName='" + Fname + "' WHERE Email='" + email + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateUserLname(string email, string Lname)
        {
            string query = "UPDATE USERR SET USERR_LName='" + Lname + "' WHERE Email='" + email + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateUserEmail(string email, string NewEmail)
        {
            string query = "UPDATE USERR SET Email='" + NewEmail + "' WHERE Email='" + email + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateUserPassword(string email, string Password)
        {
            string query = "UPDATE USERR SET Password='" + Password + "' WHERE Email='" + email + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Example()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public int SubmitUser(string Fname, string Lname, int id, DateTime DoB, string sex, string email, string pass)
        {
            string query = $"INSERT INTO USERR (USERR_FName, USERR_LName,USERR_NationalID,Date_Of_Birth,Sex,Email,USERR_Password) VALUES('{Fname}', '{Lname}', {id}, '{DoB.Date}', '{sex}', '{email}', '{pass}'); ";
            string query2 = $"INSERT INTO OnlineCustomer (OnlineCustomer_Fname, OnlineCustomer_Lname,OnlineCustomer_Email) VALUES ('{Fname}', '{Lname}', '{email}');";
            int x = dbMan.ExecuteNonQuery(query);
            if (x == 0)
                return 0;
            return dbMan.ExecuteNonQuery(query2);
        }
        public DataTable GetUserData(string email)
        {
            string query = $"SELECT * FROM OnlineCustomer WHERE OnlineCustomer_Email = '{email}';";
            return dbMan.ExecuteReader(query);
        }
        public string GetSubType(int id)
        {
            string query = $"SELECT Subscription_Type FROM Subscription WHERE Subscription_ID = {id};";
            return (string)dbMan.ExecuteScalar(query);
        }
        public int CheckPasswordMatch(string email, string password)
        {
            string query = $"SELECT COUNT(*) FROM USERR WHERE Email = '{email}' AND USERR_Password = '{password}';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable GetWarn(int id)
        {
            string query = $"SELECT * FROM Warns WHERE Passenger_SSN = '{id}';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Getbook(int id)
        {
            string query = $"SELECT * FROM Warns WHERE Passenger_SSN = '{id}';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Getcoach(int id)
        {
            string query = $"SELECT * FROM Big_Relation WHERE Trip_ID = '{id}';";
            return dbMan.ExecuteReader(query);
        }
        public int SetUpdatesandNews(string email, string news)
        {
            string query = $"INSERT INTO Manager (Manager_Email, News_Updates) VALUES ('{email}', '{news}');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int setwarn(string email, int passengerID,string reson)
        {
            string query = $"INSERT INTO Warns (TrainEmployee_Email, Passenger_SSN, Warn_Type) VALUES ('{email}', '{passengerID}', '{reson}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable select1(int id)
        {
            string query = $"SELECT * FROM Warns WHERE Passenger_SSN = '{id}';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable select2(int id)
        {
            string query = $"SELECT * FROM Trip_ID WHERE Trip_ID = '{id}';";
            return dbMan.ExecuteReader(query);
        }


    }
}
