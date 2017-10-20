namespace FirstWorkingModel
{
    public abstract class Staff
    {
        private string m_FirstName;
        private string m_LastName;
        private string m_Password;
        public enum eGender{ Male, Female};
        private eGender m_gender;

        public string FirstName { get { return m_FirstName; } set { m_FirstName = value; } }
        public string LastName { get { return m_LastName; } set { m_LastName = value; } }
        public string Password { get { return m_Password; } set { m_Password = value; } }
        public eGender Gender { get { return m_gender; } set { m_gender = value; } }
    }

    public class PracticeManager : Staff
    {
        public PracticeManager(string first, string last,eGender gender, string password)
        {

        }
    }

    public class Receptionist : Staff
    {
        public Receptionist(string first, string last, eGender gender, string password)
        {

        }
    }

    public abstract class MedStaff : Staff
    {
        private int m_permissionLevel;
        public virtual int PermissionLevel { get { return m_permissionLevel; } set { m_permissionLevel = value; } }
        public abstract void PrescribeMedication();

    }

    public class Doctor : MedStaff
    {
        public Doctor(string first, string last, eGender gender, string password)
        {

        }

        public override void PrescribeMedication()
        {

        }

        public void ApprovePrescriptionExtension(Prescription p)
        {

        }
    }
}
