/*OR Problem**/
SELECT name, population, area FROM World
WHERE population > 25000000 OR area > 3000000;


/*Case Problem**/
Update Salary
Set sex = Case
            When sex = 'm' then 'f'
            Else 'm'
            END


/*Even, Does not equal, order by Problem**/
SELECT * FROM Cinema
WHERE description <> 'boring'
AND (id%2) <> 0
ORDER BY rating desc;


/* Distinct, Group By, Having Problem */
SELECT DISTINCT email FROM Person
GROUP BY email
HAVING count(id) > 1;

/* Join on self IDs problem */
SELECT emp1.name as Employee FROM Employee emp1
INNER JOIN Employee emp2
ON emp1.managerid = emp2.id
WHERE emp1.salary > emp2.salary;

/* Not IN */
SELECT name as Customers from Customers cust
WHERE id NOT IN (SELECT customerid from Orders);


/*Cast, round, divid on self */
/* Write your T-SQL query statement below */
SELECT Request_at as Day,
ROUND((CAST((SELECT count(status) from Trips t3 WHERE STATUS = 'cancelled_by_driver' AND t3.request_at = t.request_at) AS FLOAT) /
 CAST((SELECT count(status) from Trips t2 WHERE t2.request_at = t.request_at) AS FLOAT)),2) as b
FROM Trips t
INNER JOIN Users u
on t.client_id = u.users_id
WHERE u.banned = 'No'
GROUP BY Request_at;

/* Haveing count distinct */
SELECT class FROM Courses
GROUP BY class
HAVING COUNT(DISTINCT student) >= 5 