SELECT `products`.`Name` AS `Product`, `categories`.`Name` AS `Cat` FROM `products`
LEFT JOIN `prod_cat` ON products.ID=prod_cat.ProdID
LEFT JOIN categories ON categories.ID=prod_cat.CatID