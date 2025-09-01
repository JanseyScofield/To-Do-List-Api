CREATE TABLE status(
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    description TEXT NOT NULL
);

CREATE TABLE users(
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL
);

CREATE TABLE task(
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    description TEXT NOT NULL,
    create_at TIMESTAMP NOT NULL,
    finish_at TIMESTAMP,
    status_id INTEGER NOT NULL,
    responsible_id INTEGER,
    CONSTRAINT FK_STATUS FOREIGN KEY (status_id) REFERENCES status (id),
    CONSTRAINT FK_RESPONSIBLE FOREIGN KEY (responsible_id) REFERENCES users (id)
);