Aplikasi untuk menunjang HR berbasis Windows Form C#

![image](https://github.com/user-attachments/assets/79cf1bee-a977-48a2-868f-f159a25ecb95)

Terdapat beberapa fitur seperti
1. Insert
   ![image](https://github.com/user-attachments/assets/d752cdc2-36c9-4957-af5e-95953467fecb)

2. Edit
    ![image](https://github.com/user-attachments/assets/a4435442-14d1-4f05-a8bf-eede1c04c98f)

3. Delete
   ![image](https://github.com/user-attachments/assets/01a73a8e-136a-476e-bf15-b10e237c916e)

Berikut merupakan skema database yang dibuat melalui postgresql
![image](https://github.com/user-attachments/assets/e0dd2b30-3a4f-493f-aa38-58ad7e5beb42)


```sql

BEGIN;


CREATE TABLE IF NOT EXISTS public.karyawan
(
    id_karyawan integer NOT NULL,
    nama character varying(30) NOT NULL,
    id_dep integer NOT NULL,
    PRIMARY KEY (id_karyawan)
);

CREATE TABLE IF NOT EXISTS public.departemen
(
    id_dep integer NOT NULL,
    nama_dep character varying(30) NOT NULL,
    PRIMARY KEY (id_dep)
);

ALTER TABLE IF EXISTS public.karyawan
    ADD FOREIGN KEY (id_dep)
    REFERENCES public.departemen (id_dep) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION
    NOT VALID;

END;
```
