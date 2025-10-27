namespace HospitalManagementSystem
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        public Doctor(int id, string name, string specialization)
        {
            Id = id;
            Name = name;
            Specialization = specialization;
        }
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Patient(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }

    public class HospitalRoom
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public List<Patient> Patients { get; } = new List<Patient>();

        public HospitalRoom(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
        }

        public void AddPatient(Patient patient)
        {
            if (Patients.Count < Capacity)
            {
                Patients.Add(patient);
                Console.WriteLine($"{patient.Name} доданий у палату №{RoomNumber}");
            }
            else
            {
                Console.WriteLine($"№{RoomNumber} переповнена! Неможливо додати пацієнта.");
            }
        }
    }

    public class MedicalRecord
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public MedicalRecord(Patient patient, Doctor doctor, DateTime date, string description)
        {
            Patient = patient;
            Doctor = doctor;
            Date = date;
            Description = description;
        }
    }

    public class Hospital
    {
        public List<Doctor> Doctors;
        public List<Patient> Patients;
        public List<HospitalRoom> Rooms;
        public List<MedicalRecord> Records;
        public Hospital()
        {
            Doctors = new List<Doctor>();
            Patients = new List<Patient>();
            Rooms = new List<HospitalRoom>();
            Records = new List<MedicalRecord>();
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine($"Лікар {doctor.Name} {doctor.Specialization} доданий до системи");
        }

        public void RegisterPatient(Patient patient)
        {
            Patients.Add(patient);
            Console.WriteLine($"Пацієнт {patient.Name}, {patient.Age} років, зареєстрований ");
        }

        public void CreateRoom(HospitalRoom room)
        {
            Rooms.Add(room);
            Console.WriteLine($"Палата №{room.RoomNumber} створена (місткість: {room.Capacity})");
        }

        public void HospitalizePatient(int patientId, int roomNumber)
        {
            var patient = Patients.Find(p => p.Id == patientId);
            if (patient == null)
            {
                Console.WriteLine($"Пацієнт з ID {patientId} не знайдений! ");
                return;
            }
            var room = Rooms.Find(p => p.RoomNumber == roomNumber);
            if (room == null)
            {
                Console.WriteLine($"Палата №{roomNumber} не знайдена! ");
                return;
            }

            room.AddPatient(patient);
            Console.WriteLine("метод AddPatient з класу HospitalRoom");
        }

        public void AddMedicalRecord(MedicalRecord record)
        {
            Records.Add(record);
            Console.WriteLine($"Медичний запис створено: {record.Patient.Name} -> {record.Doctor.Name}");
        }

        public List<MedicalRecord> GetPatientHistory(int patientId)
        {
            return Records.FindAll(p => p.Patient.Id == patientId);
        }

        public string GetStatistics()
        {
            int totalPatientsInRooms = Rooms.Sum(room => room.Patients.Count());
            return ($"Кількість лікарів: {Doctors.Count}\n  Кількість зареєстрованих пацієнтів: {Patients.Count}\n Кількість палат: {Rooms.Count}\n Кількість пацієнтів у палатах: {totalPatientsInRooms}\n Кількість медичних записів: {Records.Count}\n ");
        }
    }

    public class HospitalDemo
    {
        public void Run()
        {
            Hospital hospital = new Hospital();
            Doctor doctor = new Doctor(1, "Vova", "Surgeor");
            Doctor doctor2 = new Doctor(2, "Vlad", "ds");
            hospital.AddDoctor(doctor);
            hospital.AddDoctor(doctor2);
            Patient patient = new Patient(1, "Nikita", 12);
            Patient patient1 = new Patient(2, "Andrew", 32);
            Patient patient2 = new Patient(3, "Jonh", 19);
            hospital.RegisterPatient(patient);
            hospital.RegisterPatient(patient1);
            hospital.RegisterPatient(patient2);
            HospitalRoom hospitalRoom = new HospitalRoom(1, 1);
            HospitalRoom hospitalRoom1 = new HospitalRoom(2, 2);
            hospital.CreateRoom(hospitalRoom);
            hospital.CreateRoom(hospitalRoom1);
            hospital.HospitalizePatient(1, 1);
            MedicalRecord medicalRecord = new MedicalRecord(patient, doctor, DateTime.Now, "fdkso");
            MedicalRecord medicalRecord1 = new MedicalRecord(patient1, doctor2, DateTime.Now, "dksaodk");
            hospital.AddMedicalRecord(medicalRecord);
            hospital.AddMedicalRecord(medicalRecord1);
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");

            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }
            Console.WriteLine(hospital.GetStatistics());
        }
    }
}
