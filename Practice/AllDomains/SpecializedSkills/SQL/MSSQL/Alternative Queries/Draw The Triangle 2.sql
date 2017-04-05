--Hacker Rank Accepted Solution--
declare @Counter1 int, @Counter2 int, @CharToPrint varchar(1), @StringToPrint varchar(50)
select @Counter1 = 1, @CharToPrint = '*'

WHILE(@Counter1 <= 20)
BEGIN
    SELECT @Counter2 = @Counter1, @StringToPrint = '' 
    WHILE(@Counter2 > 0)
    BEGIN 
        Select @StringToPrint = @StringToPrint + ' ' + @CharToPrint
        Select @Counter2 -= 1
    END
    Print @StringToPrint
    Select @Counter1 += 1
END