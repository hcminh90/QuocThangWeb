DELIMITER $$
 
CREATE TRIGGER after_transaction_insert
AFTER INSERT
ON transactions FOR EACH ROW
BEGIN
	/*declare variable*/
	declare v_prod_unit_price bigint default 0;
    declare v_prod_amount int default 0;
    
    /*get value from products*/
    select prod_amount, prod_unit_price
    into v_prod_amount, v_prod_unit_price
    from products
    where prod_id = NEW.prod_id;
    
    /*main proc*/
    IF v_prod_unit_price = NEW.prod_unit_price THEN
		CASE NEW.transaction
			WHEN 'sell' THEN
				IF v_prod_amount >= NEW.unit_amount THEN
					set v_prod_amount = v_prod_amount - NEW.unit_amount;
				ELSE
					SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'So luong ban khong duoc vuot qua ton kho!';
                END IF;
                
			WHEN 'buy' THEN
				IF NEW.unit_amount > 0  THEN
					set v_prod_amount = v_prod_amount + NEW.unit_amount;
				ELSE
					SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'So luong nhap phai lon hon 0!';
                END IF;
		END CASE;
		/*update prod_amount*/
		update products set prod_amount = v_prod_amount where prod_id = NEW.prod_id;
	ELSE
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Don gia goc da cap nhat!';
    END IF;
END$$
 
DELIMITER ;