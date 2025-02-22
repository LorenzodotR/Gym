
CREATE TABLE IF NOT EXISTS "User" (
	"id" varchar(255) NOT NULL UNIQUE,
	"name" varchar(300) NOT NULL,
	"email" varchar(300) NOT NULL,
	"password" varchar(300) NOT NULL,
	PRIMARY KEY ("id")
);

CREATE TABLE IF NOT EXISTS "training_sheet" (
	"id" serial NOT NULL UNIQUE,
	"name" varchar(300) NOT NULL,
	"description" varchar(300) NOT NULL,
	"User_ID" varchar(255) NOT NULL,
	PRIMARY KEY ("id")
);

CREATE TABLE IF NOT EXISTS "exercise" (
	"id" serial NOT NULL UNIQUE,
	"name" varchar(300) NOT NULL,
	"repeat" bigint NOT NULL,
	"weight" bigint NOT NULL,
	"sets" bigint NOT NULL,
	"pause" bigint NOT NULL,
	"muscle_group_id" bigint NOT NULL,
	PRIMARY KEY ("id")
);

CREATE TABLE IF NOT EXISTS "muscle_group" (
	"id" serial NOT NULL UNIQUE,
	"name" bigint NOT NULL,
	"description" bigint NOT NULL,
	"training_sheets_id" bigint NOT NULL,
	PRIMARY KEY ("id")
);

CREATE TABLE IF NOT EXISTS "frequency" (
	"id" serial NOT NULL UNIQUE,
	"data" date NOT NULL,
	"attendance" boolean,
	"User_ID" bigint NOT NULL,
	PRIMARY KEY ("id")
);

CREATE TABLE IF NOT EXISTS "Extra_Activities" (
	"id" serial NOT NULL UNIQUE,
	"name" varchar(255) NOT NULL,
	"description" varchar(255) NOT NULL,
	"frequency_id" bigint NOT NULL,
	PRIMARY KEY ("id")
);

CREATE TABLE IF NOT EXISTS "Goals" (
	"id" serial NOT NULL UNIQUE,
	"type" bigint NOT NULL,
	"target" bigint NOT NULL,
	"date_start" date NOT NULL,
	"date_end" date NOT NULL,
	"Create_at" timestamp without time zone NOT NULL,
	"User_ID" varchar(255) NOT NULL,
	PRIMARY KEY ("id")
);

CREATE TABLE IF NOT EXISTS "training_history" (
	"id" serial NOT NULL UNIQUE,
	"weight" bigint NOT NULL,
	"repetitions" bigint NOT NULL,
	"sets" bigint NOT NULL,
	"create_at" timestamp without time zone NOT NULL,
	"User_ID" bigint NOT NULL,
	"training_sheet_id" bigint NOT NULL,
	PRIMARY KEY ("id")
);

CREATE TABLE IF NOT EXISTS "Notifications" (
	"id" serial NOT NULL UNIQUE,
	"message" bigint NOT NULL,
	"send_at" bigint NOT NULL,
	"status" bigint NOT NULL,
	"Goals_ID" bigint NOT NULL,
	"User_ID" varchar(255) NOT NULL,
	PRIMARY KEY ("id")
);


ALTER TABLE "training_sheet" ADD CONSTRAINT "training_sheet_fk3" FOREIGN KEY ("User_ID") REFERENCES "User"("id");
ALTER TABLE "exercise" ADD CONSTRAINT "exercise_fk6" FOREIGN KEY ("muscle_group_id") REFERENCES "muscle_group"("id");
ALTER TABLE "muscle_group" ADD CONSTRAINT "muscle_group_fk3" FOREIGN KEY ("training_sheets_id") REFERENCES "training_sheet"("id");
ALTER TABLE "frequency" ADD CONSTRAINT "frequency_fk3" FOREIGN KEY ("User_ID") REFERENCES "User"("id");
ALTER TABLE "Extra_Activities" ADD CONSTRAINT "Extra_Activities_fk3" FOREIGN KEY ("frequency_id") REFERENCES "frequency"("id");
ALTER TABLE "Goals" ADD CONSTRAINT "Goals_fk6" FOREIGN KEY ("User_ID") REFERENCES "User"("id");
ALTER TABLE "training_history" ADD CONSTRAINT "training_history_fk5" FOREIGN KEY ("User_ID") REFERENCES "User"("id");

ALTER TABLE "training_history" ADD CONSTRAINT "training_history_fk6" FOREIGN KEY ("training_sheet_id") REFERENCES "training_sheet"("id");
ALTER TABLE "Notifications" ADD CONSTRAINT "Notifications_fk4" FOREIGN KEY ("Goals_ID") REFERENCES "Goals"("id");

ALTER TABLE "Notifications" ADD CONSTRAINT "Notifications_fk5" FOREIGN KEY ("User_ID") REFERENCES "User"("id");