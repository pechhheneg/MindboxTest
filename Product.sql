SELECT name_product,name_category FROM Products
left join Categories
on Products.category= name_category
group by name_product;