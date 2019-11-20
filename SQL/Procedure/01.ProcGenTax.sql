DELIMITER $$

CREATE PROCEDURE ProcGenTax(out outtax_id varchar(100))
BEGIN
    declare current_tax varchar(20);
    declare i int;
    
    select distinct tax_id
    into current_tax
    from transcations
    where timestamp >= current_date - 30
    order by 1 desc
    limit 1;
    
    if current_tax is null 
    then 
		set i = 1;
	else
		set i = convert(SUBSTRING_INDEX(current_tax,'-',-1),UNSIGNED INTEGER);
	end if;
    
    set outtax_id = concat('PX-', lpad(i,8,'0'));

END$$
 
DELIMITER ;