namespace Models
{
    public partial class LOUE
    {
        public override string ToString()
        {
            return string.Format("{0} - Id client : {1}, Id vehicule : {2}, {3}Km  du {4} au {5}",
                ID, ID_CLIENT, ID_VEHICULE, NB_KM,
                DATE_DEBUT.ToString("dd/MM/yyyy"), DATE_FIN?.ToString("dd/MM/yyyy"));
        }
    }
}
