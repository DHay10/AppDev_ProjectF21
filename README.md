# **AppDev_Project**

## **Table Of Content**

- [**AppDev_Project**](#appdev_project)
  - [**Table Of Content**](#table-of-content)
  - [**Description**](#description)
  - [**Main Functions**](#main-functions)
    - [Dashboard View](#dashboard-view)
    - [Database Interface](#database-interface)
    - [Student File View](#student-file-view)
    - [New Student Creation View](#new-student-creation-view)
  - [**To-do List**](#to-do-list)
    - [General](#general)
    - [Specific](#specific)
  - [Database](#database)

## **Description**

- This GUI-based application is for the A21 Application Development Final Project.
- A student information system with database (SISD) will enable the school to track and manage all their student data, information, and progress. This will help a school with a huge population of students to better manage the student’s data. This information will be inputted by the user/school. The idea of this application is so the user has a fast way to acquire or update their student’s information without the need for a more complex program. Students’ information will be inputted by the user, and it will be saved in a CSV file (Comma Separated Values) that will later be ready to be treated by a more complex database management system.

## **Main Functions**

### Dashboard View

- This view is a global dashboard that will give access to all the other views, time/date, user info, and will be the general menu for the application.

### Database Interface

- This view is a table view of all students can be filtered/sorted or searched through to show all the essentials values of Students.

### Student File View

- This view is the summary of the file of a selected student. It will show data fields of essentials values. Theses can be also updated to new values if the select button is clicked.

### New Student Creation View

- This view is the creation of a new student, it will offer datafields that will need to be filled and some that will be optional to fill. This will also assign an unique `StudentID` to the new created instance in the system.

## **To-do List**

### General

- [ ] Design Database
- [ ] Student Class
- [ ] Admin Class
- [ ] Implement Login Screen
  - [ ] Admin Creation
- [ ] Implement Dashboard View (Main Menu)
  - [ ] Make link to New Student View
  - [ ] Make link to Database View
- [ ] Clean GUI
- [ ] Add Theme

### Specific

- [ ] Duplicates
- [ ] Error Messages
- [ ] Specific Cases(Number/Symbols)
- [ ] Implement New Student View (`Sarah`)
  - [ ] Input Fields
    - [ ] First Name / Last Name
    - [ ] Parents' contact info
    - [ ] Siblings in School (Optional)
    - [ ] Address
      - [ ] Number
      - [ ] Street Name
      - [ ] App/Suite/Other (Optional)
      - [ ] Postal Code
      - [ ] City
      - [ ] Country
      - [ ] Phone Number
    - [ ] Return Button
    - [ ] Save Button
    - [ ] Preview File
- [ ] Implement Database View (`Andy`)
  - [ ] Add database reading
    - [ ] Add column with values
  - [ ] Add Sort/Filtering Function
  - [ ] Add Search Box Function
  - [ ] Link to Student File View
- [ ] Implement Student View (`Hendrick`)
  - [ ] Show values
  - [ ] Update Info Function
  - [ ] Next/Previous Button
  - [ ] Return Button
  - [ ] Add grades
  - [ ] Delete Function

## Database

StudentID | FirstName | LastName | AddressNum | StreetName | SecondaryNum | City | Province | Country | Phone
--------|----------|----------|-----------|---------|--------|--------|-------|--------|---
(Unique)(PK) Int | String | String | Int | String | String | String | String | String
00001 | Andy | Nguyen-Chao | 212 | Av. Christophe-Colomb | 203 | Montreal | Montreal | QC | 514-382-7919