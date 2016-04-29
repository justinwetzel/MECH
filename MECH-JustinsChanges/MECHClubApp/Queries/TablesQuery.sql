-- createdb mech_db
-- type "psql mech_db" on the command line
-- CREATE DATABASE mech_db_test;

CREATE TABLE "parts" (
    "part_id" integer IDENTITY(1,1),
    "part_name" text,
    "price" money,
    "quantity" integer,
    "type" text,
    "vendor" text,
    "vendor_url" text,
    PRIMARY KEY ("part_id")
);

CREATE TABLE "projects" (
    "proj_id" integer IDENTITY(1,1),
    "proj_name" text,
    "version" real,
    "contributors" text,
    "image_url" text,
    "description" text,
    PRIMARY KEY ("proj_id")
);

CREATE TABLE "project_parts" (
    "proj_parts_id" integer IDENTITY(1,1),
    "proj_id" integer,
    "part_id" integer,
    "quantity_need" integer,
    PRIMARY KEY ("proj_parts_id"),
    FOREIGN KEY ("proj_id") REFERENCES "projects"("proj_id"),
    FOREIGN KEY ("part_id") REFERENCES "parts"("part_id"),
    UNIQUE("proj_id", "part_id")
);

--location(STRING)	event_cost(REAL)

CREATE TABLE "events" (
    "event_id" integer IDENTITY(1,1),
    "proj_id" integer,
    "e_date" date,
    "event_name" text,
    "location" text,
    "event_cost" money,
    PRIMARY KEY ("event_id"),
    FOREIGN KEY ("proj_id") REFERENCES "projects"("proj_id")
);

CREATE TABLE "orders" (
    "order_id" integer IDENTITY(1,1),
    "order_number" integer,
    "part_id" integer,
    "status" text,
    "costs" money,
    "quantity" integer,
    "o_date" date,
    PRIMARY KEY ("order_id"),
    FOREIGN KEY ("part_id") REFERENCES "parts"("part_id"),
    UNIQUE("order_number", "part_id")
);
