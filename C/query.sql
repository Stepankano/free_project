SELECT p.product, c.category 
FROM productTable p
LEFT JOIN categoryTable c ON p.id = c.id;