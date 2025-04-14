--
-- PostgreSQL database dump
--

-- Dumped from database version 17.4
-- Dumped by pg_dump version 17.4

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: groups; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.groups (
    group_id integer NOT NULL,
    group_number integer NOT NULL,
    institut_id integer NOT NULL,
    specialtet_id integer
);


ALTER TABLE public.groups OWNER TO postgres;

--
-- Name: institutes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.institutes (
    institut_id integer NOT NULL,
    name_institute character varying(200) NOT NULL,
    full_name character varying(200) NOT NULL,
    title_dean character varying(100) NOT NULL
);


ALTER TABLE public.institutes OWNER TO postgres;

--
-- Name: specialties; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.specialties (
    specialtet_id integer NOT NULL,
    specialtet_identifier character varying(50) NOT NULL,
    specialtet_name character varying(200) NOT NULL,
    institut_id integer NOT NULL
);


ALTER TABLE public.specialties OWNER TO postgres;

--
-- Name: students; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.students (
    student_id integer NOT NULL,
    full_name character varying(200),
    year_admission integer NOT NULL,
    date_birth date NOT NULL,
    group_id integer NOT NULL
);


ALTER TABLE public.students OWNER TO postgres;

--
-- Data for Name: groups; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.groups (group_id, group_number, institut_id, specialtet_id) FROM stdin;
1	1520321	1	1
2	1521621	1	2
3	1521721	1	3
4	1680131	2	4
5	1680831	2	5
6	1720221	3	6
\.


--
-- Data for Name: institutes; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.institutes (institut_id, name_institute, full_name, title_dean) FROM stdin;
1	Институт передовых информационных технологий	Привалов Александр Николаевич	профессор
2	Институт инновационных образовательных практик	Белянкова Елена Ивановна	доцент
3	Институт туризма и креативных индустрий	Маркова Светлана Михайловна	кандидат исторических наук
\.


--
-- Data for Name: specialties; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.specialties (specialtet_id, specialtet_identifier, specialtet_name, institut_id) FROM stdin;
1	02.03.02	 ФУНДАМЕНТАЛЬНАЯ ИНФОРМАТИКА И ИНФОРМАЦИОННЫЕ ТЕХНОЛОГИИ	1
2	02.03.03	МАТЕМАТИЧЕСКОЕ ОБЕСПЕЧЕНИЕ И АДМИНИСТРИРОВАНИЕ ИНФОРМАЦИОННЫХ СИСТЕМ	1
3	09.03.03	ПРИКЛАДНАЯ ИНФОРМАТИКА	1
4	44.04.01	Педагогическое образование	2
5	43.03.02	Туризм	3
\.


--
-- Data for Name: students; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.students (student_id, full_name, year_admission, date_birth, group_id) FROM stdin;
1	Матвеева Анастасия Тимофеевна	2021	2004-02-18	1
2	Соболева Виктория Глебовна	2021	2004-04-06	2
3	Новиков Леонид Егорович	2022	2004-12-13	4
4	Дегтярева Екатерина Сергеевна	2021	2004-11-06	5
5	Моисеев Артемий Марсельевич	2022	2004-06-01	3
6	Грачев Игорь Даниилович	2022	2004-07-10	1
7	Богданов Михаил Кириллович	2021	2003-11-06	1
8	Александров Владимир Тимурович	2022	2004-10-03	3
9	Булгаков Артём Глебович	2021	2003-10-12	6
10	Васильев Роман Германович	2021	2004-10-23	6
11	Соболева София Тимуровна	2022	2004-11-08	2
12	Карпов Андрей Александрович	2021	2003-07-22	3
13	Романов Никита Александрович	2022	2004-07-21	2
14	Аникин Александр Олегович	2022	2003-11-11	4
\.


--
-- Name: groups groups_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.groups
    ADD CONSTRAINT groups_pkey PRIMARY KEY (group_id);


--
-- Name: institutes institutes_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.institutes
    ADD CONSTRAINT institutes_pkey PRIMARY KEY (institut_id);


--
-- Name: specialties specialties_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.specialties
    ADD CONSTRAINT specialties_pkey PRIMARY KEY (specialtet_id);


--
-- Name: specialties specialties_specialtet_identifier_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.specialties
    ADD CONSTRAINT specialties_specialtet_identifier_key UNIQUE (specialtet_identifier);


--
-- Name: students students_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.students
    ADD CONSTRAINT students_pkey PRIMARY KEY (student_id);


--
-- Name: groups groups_institut_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.groups
    ADD CONSTRAINT groups_institut_id_fkey FOREIGN KEY (institut_id) REFERENCES public.institutes(institut_id);


--
-- Name: specialties specialties_institut_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.specialties
    ADD CONSTRAINT specialties_institut_id_fkey FOREIGN KEY (institut_id) REFERENCES public.institutes(institut_id);


--
-- Name: students students_group_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.students
    ADD CONSTRAINT students_group_id_fkey FOREIGN KEY (group_id) REFERENCES public.groups(group_id);


--
-- PostgreSQL database dump complete
--

