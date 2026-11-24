CREATE TABLE countries (
    id INT PRIMARY KEY,
    country VARCHAR(50) NOT NULL
);

CREATE TABLE demographics (
    year INT NOT NULL,
    country_id INT NOT NULL,
    population INT NOT NULL,
    FOREIGN KEY (country_id) REFERENCES countries(id)
);

CREATE TABLE economics (
    year INT NOT NULL,
    country_id INT NOT NULL,
    gdp_growth DECIMAL(5,2),
    inflation DECIMAL(5,2),
    FOREIGN KEY (country_id) REFERENCES countries(id)
);