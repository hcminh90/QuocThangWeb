DELIMITER $$
 
CREATE TRIGGER after_transcation_insert
AFTER INSERT
ON transcations FOR EACH ROW
BEGIN
	declare v_prod_amount int default 0;
    select prod_amount into v_prod_amount
    from products
    where prod_id = NEW.prod_id;
    
    CASE NEW.transaction
		WHEN 'sell' THEN
			set v_prod_amount = v_prod_amount - NEW.unit_amount;
        WHEN 'buy' THEN
			set v_prod_amount = v_prod_amount + NEW.unit_amount;
    END CASE;
    
    update products set prod_amount = v_prod_amount where prod_id = NEW.prod_id;
    
END$$
 
DELIMITER ;