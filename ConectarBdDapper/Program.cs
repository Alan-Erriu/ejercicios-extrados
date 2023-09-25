using ConectarBdDapper.Data;




using (DataUser dataUser = new DataUser())
{
    dataUser.getUsers();
    dataUser.GetUserById(1);
}

