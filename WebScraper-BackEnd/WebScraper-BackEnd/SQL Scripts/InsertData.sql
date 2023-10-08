-- The initial SQL I ran to create the database
CREATE DATABASE SearchesDB


-- I ran 'Add-Migration AddTable' and 'Update-Database' in Package Manager Console to generate my table (part of EF Core)
-- But here is the SQL to create the table
CREATE TABLE Searches (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    SearchTerms NVARCHAR(MAX) NOT NULL,
    Url NVARCHAR(MAX) NOT NULL,
    Occurrences NVARCHAR(MAX) NOT NULL,
    Timestamp DATETIME2(7) NOT NULL
); 

-- Here is the query to add the current data in the Searches table at the time of writing
INSERT INTO Searches (SearchTerms, Url, Occurrences, Timestamp)
VALUES
('hello', 'www.youtube.com', '[1,17,18,19,20,60,61]', '2023-10-08 12:52:23.894'),
('land registry search', 'www.infotrack.co.uk', '[14]', '2023-10-08 12:54:33.604'),
('hello', 'www.youtube.com', '[1,17,18,19,20,60,61]', '2023-10-08 13:04:04.609'),
('cristiano ronaldo', 'www.youtube.com', '[65,66]', '2023-10-08 13:05:44.678'),
('chelsea', 'www.skysports.com', '[25,34]', '2023-10-08 13:22:51.313')
