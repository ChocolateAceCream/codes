USE pubs
GO

SELECT * FROM authors
SELECT * FROM titleauthor
SELECT * FROM titles

INSERT INTO authors(au_id,au_lname,au_fname,phone,address,city,state,zip,contract)
VALUES('111-22-3333','Smitty','Brianna','555 123-1234','123 Main St','Clemmons', 'NC', '27222',1)

INSERT INTO authors(au_id,au_lname,au_fname,phone,address,city,state,zip,contract)
VALUES('222-22-3333','Smitty','Bobby','555 123-1234','123 Main St','Clemmons', 'NC', '27222',1)

INSERT INTO TITLES (title_id,title,type,pub_id,price,advance,royalty,ytd_sales,notes,pubdate)
SELECT 'WX1111',title,type,pub_id,price,advance,royalty,ytd_sales,notes,pubdate
FROM titles
WHERE title_id = 'BU1032'

INSERT INTO titleauthor(au_id,title_id,au_ord,royaltyper)
VALUES('111-22-3333','WX1111',1,100)

SELECT * 
FROM authors
LEFT JOIN titleauthor
   ON authors.au_id = titleauthor.au_id
LEFT JOIN titles
   ON titles.title_id = titleauthor.title_id
WHERE authors.au_id = '111-22-3333' OR authors.au_id = '222-22-3333'

SELECT * 
FROM authors
INNER JOIN titleauthor
   ON authors.au_id = titleauthor.au_id
INNER JOIN titles
   ON titles.title_id = titleauthor.title_id
WHERE authors.au_id = '111-22-3333' OR authors.au_id = '222-22-3333'
