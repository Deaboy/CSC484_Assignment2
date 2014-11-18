/* Tables */
CREATE TABLE Physician(
	ID BIGINT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Name VARCHAR(63),
	Specialty VARCHAR(63)
);

CREATE TABLE Patient(
	ID BIGINT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Name VARCHAR(63) ,
	PhoneNumber VARCHAR(15),
	ContactName VARCHAR(63),
	ContactNumber VARCHAR(15),
	PhysicianID BIGINT NOT NULL,
	
	INDEX ind_patient_physicianid (PhysicianID ASC)
	CONSTRAINT fk_patient_physicianid
		FOREIGN KEY (PhysicianID)
		REFERENCES Physician(ID)
		ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE Treatment(
	ID BIGINT PRIMARY KEY NOT NULL IDENTITY (1,1),
	Name VARCHAR(63),
	StartTime TIME,
	EndTime TIME,
	PatientID BIGINT NOT NULL,
	PhysicianID BIGINT NOT NULL,

	INDEX ind_treatment_patientid (PatientID ASC),
	INDEX ind_treatment_physicanid (PhysicianID ASC),
	CONSTRAINT fk_treatment_patientid
		FOREIGN KEY (PatientID)
		REFERENCES Patient(ID)
		ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT fk_treatment_physicianid 
		FOREIGN KEY (PhysicianID)
		REFERENCES Physician(ID)
		ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Medication(
	ID BIGINT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Drug VARCHAR(127),
	Dosage INT,
	StartDate DATE,
	EndDate DATE,
		PatientID BIGINT NOT NULL,

	INDEX ind_medication_patientid (PatientID),
	CONSTRAINT fk_medication_patientid
		FOREIGN KEY (PatientID)
		REFERENCES Patient(ID)
		ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE LabExam(
	ID BIGINT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Date DATE,
	Time TIME,
	PatientID BIGINT NOT NULL,

	INDEX ind_labexam_patientid (PatientID),
	CONSTRAINT fk_labexam_patientid
		FOREIGN KEY (PatientID)
		REFERENCES Patient(ID)
		ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE SpecialDiet(
	ID BIGINT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Breakfast VARCHAR(127),
	Lunch	VARCHAR(127),
	Dinner VARCHAR(127),
	PatientID BIGINT NOT NULL,
	
	INDEX ind_specialdiet_patientid (PatientID),
	CONSTRAINT fk_specialdiet_patientid
		FOREIGN KEY (PatientID)
		REFERENCES Patient(ID)
		ON DELETE CASCADE ON UPDATE CASCADE
);

