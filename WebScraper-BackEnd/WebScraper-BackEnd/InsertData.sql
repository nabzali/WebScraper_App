  -- Insert one line of example data
INSERT INTO [SearchesDB].[dbo].[Searches] ([SearchTerms], [Url], [Occurrences], [Timestamp])
VALUES ('Example Search 1', 'http://example.com/1', '[5, 87]', GETDATE())

-- Insert another line of example data
INSERT INTO [SearchesDB].[dbo].[Searches] ([SearchTerms], [Url], [Occurrences], [Timestamp])
VALUES ('Example Search 2', 'http://example.com/2', '[3, 23]', GETDATE())
