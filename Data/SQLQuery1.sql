SELECT        '30Days' AS DateRange, a.AgencyName, SUM(j.TotalPayment) AS Total
FROM            Job AS j INNER JOIN
                         Agency AS a ON a.AgencyId = j.AgencyId
WHERE        (j.PaymentReceived = 0) AND (j.EndJob BETWEEN DATEADD(mm, -1, GETDATE()) AND GETDATE())
GROUP BY a.AgencyName
UNION
SELECT        'Sum30Days' AS DateRange, 'ALL', SUM(j.TotalPayment) AS Total
FROM            Job AS j INNER JOIN
                         Agency AS a ON a.AgencyId = j.AgencyId
WHERE        (j.PaymentReceived = 0) AND (j.EndJob BETWEEN DATEADD(mm, -1, GETDATE()) AND GETDATE())

UNION



SELECT        '60Days' AS DateRange, a.AgencyName, SUM(j.TotalPayment) AS Total
FROM            Job AS j INNER JOIN
                         Agency AS a ON a.AgencyId = j.AgencyId
WHERE        (j.PaymentReceived = 0) AND (j.EndJob BETWEEN DATEADD(mm, -2, GETDATE()) AND DATEADD(mm, -1, GETDATE()))
GROUP BY a.AgencyName
UNION
SELECT        '90Days' AS DateRange, a.AgencyName, SUM(j.TotalPayment) AS Total
FROM            Job AS j INNER JOIN
                         Agency AS a ON a.AgencyId = j.AgencyId
WHERE        (j.PaymentReceived = 0) AND (j.EndJob BETWEEN DATEADD(mm, -3, GETDATE()) AND DATEADD(mm, -2, GETDATE()))
GROUP BY a.AgencyName
UNION
SELECT        'Over90Days' AS DateRange, a.AgencyName, SUM(j.TotalPayment) AS Total
FROM            Job AS j INNER JOIN
                         Agency AS a ON a.AgencyId = j.AgencyId
WHERE        (j.PaymentReceived = 0) AND (j.EndJob < DATEADD(mm, -3, GETDATE()))
GROUP BY a.AgencyName


SELECT        'Sum30Days' AS DateRange, SUM(j.TotalPayment) AS Total
FROM            Job AS j
WHERE        (j.PaymentReceived = 0) AND (j.EndJob BETWEEN DATEADD(mm, -1, GETDATE()) AND GETDATE())
UNION
SELECT        'Sum60Days' AS DateRange, SUM(j.TotalPayment) AS Total
FROM            Job AS j 
WHERE        (j.PaymentReceived = 0) AND (j.EndJob BETWEEN DATEADD(mm, -2, GETDATE()) AND DATEADD(mm, -1, GETDATE()))
UNION
SELECT        'Sum90Days' AS DateRange, SUM(j.TotalPayment) AS Total
FROM            Job AS j 
WHERE        (j.PaymentReceived = 0) AND (j.EndJob BETWEEN DATEADD(mm, -3, GETDATE()) AND DATEADD(mm, -2, GETDATE()))
UNION
SELECT        'Over90Days' AS DateRange, SUM(j.TotalPayment) AS Total
FROM            Job AS j 
WHERE        (j.PaymentReceived = 0) AND (j.EndJob < DATEADD(mm, -3, GETDATE()))




                    SELECT 'Sum30Days' AS DateRange, SUM(j.TotalPayment) AS Total FROM Job AS j WHERE(j.PaymentReceived = 0) AND 
                    (j.EndJob BETWEEN DATEADD(mm, -1, GETDATE()) AND GETDATE()) UNION 
                    SELECT 'Sum60Days' AS DateRange, SUM(j.TotalPayment) AS Total FROM Job AS j WHERE(j.PaymentReceived = 0) AND 
                    (j.EndJob BETWEEN DATEADD(mm, -2, GETDATE()) AND DATEADD(mm, -1, GETDATE())) UNION
                    SELECT 'Sum90Days' AS DateRange, SUM(j.TotalPayment) AS Total FROM Job AS j WHERE(j.PaymentReceived = 0) AND 
                    (j.EndJob BETWEEN DATEADD(mm, -3, GETDATE()) AND DATEADD(mm, -2, GETDATE())) UNION
                    SELECT 'Over90Days' AS DateRange, SUM(j.TotalPayment) AS Total FROM Job AS j WHERE(j.PaymentReceived = 0) AND 
                    (j.EndJob < DATEADD(mm, -3, GETDATE()))