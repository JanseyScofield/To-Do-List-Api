CREATE TABLE Status(
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);

CREATE TABLE Users(
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL
);

CREATE TABLE Task(
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Description TEXT NOT NULL,
    Create_at TIMESTAMP NOT NULL,
    Finish_at TIMESTAMP,
    Status_id INTEGER NOT NULL,
    Responsible_id INTEGER,
    CONSTRAINT FK_STATUS FOREIGN KEY (Status_id) REFERENCES status (Id),
    CONSTRAINT FK_RESPONSIBLE FOREIGN KEY (Responsible_id) REFERENCES users (Id)
);

INSERT INTO Status(Name) VALUES ('Created'), ('InProgress'), ('Finished'), ('Canceled')