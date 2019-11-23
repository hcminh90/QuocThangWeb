DELIMITER $$
 
CREATE TRIGGER after_transaction_update
AFTER UPDATE
ON transactions FOR EACH ROW
BEGIN
	declare v_prod_amount int default 0;
    IF NEW.unit_amount <=> OLD.unit_amount 
		and NEW.tax_id = OLD.tax_id
        and NEW.prod_id = OLD.prod_id
        and NEW.cust_id = OLD.cust_id
        and NEW.timestamp = OLD.timestamp THEN
		select prod_amount into v_prod_amount
		from products
		where prod_id = NEW.prod_id;
		
		CASE NEW.transaction
			WHEN 'sell' THEN
				set v_prod_amount = v_prod_amount + NEW.unit_amount - OLD.unit_amount;
			WHEN 'buy' THEN
				set v_prod_amount = v_prod_amount - NEW.unit_amount + OLD.unit_amount;
		END CASE;
		
		update products set prod_amount = v_prod_amount where prod_id = NEW.prod_id;
    END IF;
END$$
 
DELIMITER ;