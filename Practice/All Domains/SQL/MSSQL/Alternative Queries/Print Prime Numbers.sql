/* Hackerrank accepted solution */
Declare @Target Int, @NextNo Int, @Counter Int, @ModOp int, @StringToPrint varchar(max), @IsPrime bit
select @Target = 1000, @NextNo = 2, @StringToPrint = ''

While @NextNo < @Target
BEGIN 
	select @Counter = 2, @IsPrime = 1
	While @Counter < @NextNo
	BEGIN 
		set @ModOp = @NextNo % @Counter
		if(@ModOp = 0)
		BEGIN
			set @IsPrime = 0
		END
		--Select @NextNo as NextNo, @Counter as Counter , @ModOp as ModOp
		set @Counter += 1	
	END
	--Select @NextNo as NextNo, @IsPrime as IsPrime
	if(@IsPrime = 1)
	BEGIN
		if(@StringToPrint != '') BEGIN set @StringToPrint += '&' END
		set @StringToPrint += Convert(varchar(10),@NextNo) 
	END
	set @NextNo += 1
END

print @StringToPrint