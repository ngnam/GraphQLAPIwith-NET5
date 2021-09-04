-- Insert rows into table 'TableName'
INSERT INTO Platforms
    ( -- columns to insert data into
    Name, LisenceKey
    )
VALUES
    ( -- first row: values for the columns in the list above
        '.NET 5', NULL
),
    ( -- second row: values for the columns in the list above
        'Docker', NULL
),
    (
        'Windows', '41213123123'
)
-- add more rows here
GO