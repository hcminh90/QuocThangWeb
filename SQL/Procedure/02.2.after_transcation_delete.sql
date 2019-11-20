DELIMITER $$
 
CREATE TRIGGER after_transcation_delete
AFTER DELETE
ON transcations FOR EACH ROW
BEGIN
	declare v_prod_amount int default 0;
    select prod_amount into v_prod_amount
    from products
    where prod_id = OLD.prod_id;
    
    CASE OLD.transaction_desc
		WHEN 'sell' THEN
			set v_prod_amount = v_prod_amount + OLD.unit_amount;
        WHEN 'buy' THEN
			set v_prod_amount = v_prod_amount - OLD.unit_amount;
    END CASE;
    
    update products set prod_amount = v_prod_amount where prod_id = OLD.prod_id;
    
END$$
 
DELIMITER ;