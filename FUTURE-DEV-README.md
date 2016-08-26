ADVICE:
=======
SERIOUSLY READ ALL THE COMMENTS! I tried to keep them updated and informative.
It's a good place to start. But seriously! Spend a few days reading the code and
all the comments. Trace the flow. The program starts in the PCW form and goes
from there. **Unfortunately**, there are a lot of features where this software
is tightly coupled to GPM since this application creates the database entries
that GPM has to use. If you don't know what's going on, ask Daniel Dainwood
(or whomever is coding on GPM at the time of reading this).

DESIGN DECISIONS:
=================
There are definitely some "design flaws" in that it is not a nice, arch.
without a lot of tight coupling -- there is quite a bit of tight coupling
unfortunately. Tread carefully lest you break EVERYTHING. Also, there's not
really a testing framework so unless you know what to actually look for, you
won't even know that you've broken everything. I know. I'm sorry. But in my
defense, I did the best I could with what I was given -- absolutely nothing!
Anyway, I'm trying to clean this up. It's kind of an MVC, but it's a slopy
MVC at best. The design "View" is the auto-generated designer code. I liked
to visually design everything. It was easiest for me. So the design and
front-end interaction is in the ViewController. State and logic is supposed to
be in the Model which are the `_Data` files. The worst piece of shit code that
had to be written was the `DataAddedToHash`. Basically, it's a gangsta' drive-
by that collects all the needed data from each Step into a single hash. The
data is then "parsed" to get what's needed to put into the database for the
given task at hand. I dislike SQL strings so I went with LINQ. It's actually
really cool. Spend some time learning LINQ to understand how the data gets to
the database. Also, my naming convensions weren't that good. I didn't really
know what things should do what and when throughout the process. It was kind
of trial-by-fire. Towards the end, I started using more descriptive names, but
until then, it was just letters -- actually, I started with numbers, but then
had to rearrange things and switched to letters for some reason. I don't know.

VERSION CONTROL (GIT):
======================
The application was kept in git version control and (strikethrough)---pushed
to a remote, private repo hosted on github.com--- [It WAS pushed to a private
repo, but my trial for free private repos on github expired. I was a wreck.
I just didn't know what to do with myself without being able to securely push
code to a safe, remote location. I did what had to be done. I set up Oaklawn's
own Gitlab server! This is a virtual server on vcenter-view. It's DNS name is
it-gitlab.it.ojc.local. You need to use ActiveDirectory to make yourself a
MemberOf GitLab. After you've done that, you can access Gitlab at:
http://it-gitlab.it.ojc.local. You LDAP credentials are your regular username
(example: rdillin) and your regular Oaklawn password.]. Fork my PWC on Gitlab,
and then use git to clone the project so you can have your own copy of the
code. Please, please, please take the time to set up your git version control.
DO NOT MAKE YOUR OWN COPY OF MY CODE BY COPY-PASTING THE FOLDER INTO YOUR OWN
FOLDER IN "I:\Projects\(Your Name)"! SERIOUSLY! ACT LIKE YOU CAN'T ACCESS THE
CODE DIRECTLY LIKE THAT! GET YOUR OWN COPY THROUGH GIT! Being able to roll
back to earlier versions of software is invaluable. Even if you are only a
single developer on this project, it is still good practice to use version
control software.

ADDENDUM (08/25/16): I have no idea what happeded to the GitLab vm. I cannot
access the code or anything. I believe that the ActiveDirectory was messed up.
Anyway, I'm putting a copyleft, GNU license on the code and pushing it to Github.
Do whatever you need to do to get work done. In my more youthful, zealous days, I
was very adament about version control and git. I still swear by git; use it!
But I understand that you need to do what you need to do.

ADDENDUM (08/26/16): https://github.com/rastreus/PCW. FORK IT, BRUH!

READABILITY AND MANTAINABILITY:
===============================
I know some of the horrible design issues makes this difficult. But there is
one thing that I need to seriously make you understand right now. 80 columns
is a standard for a reason! It's a holy institution! USE IT! In VB.NET there
is a thing called the "whitespace operator." It's the underscore ( _ ).
Look it up. Read about it. You will notice it a lot throughout this code. I
hold it near and dear to my heart. SERIOUSLY! Follow a programming style of
staying true to 80 columns. Do not let a single line of code go even a single
character over 80 columns. That would mean a lot to me. Thank you.

ADDENDUM (08/25/16): This is too humorous. Do whatever you have to do. I love
programming style and 80 columns. I used a vertical monior for programming instead
of a horizontal monitor so I literally couldn't go too much further past 80 cols.

UPDATING:
=========
The steps to update the application are on the "frmAutoUpdate.vb" file.
I am copying them here as well:

On each new release of PCW that needs to be pushed out:

OBVIOUSLY UPDATE THE VERSION NUMBER BEFORE PUSHING THE UPDATE!
PromotionalCreationWizard > Properties > Application > Assembly Information
Update the Assembly Version and the File Version.
EXAMPLE: As of 08/25/16, the current version is 0.9.0.4.
If I were updating, I would simply change the version to 0.9.0.5.

The following steps use examples of updating from 0.9.0.4 to 0.9.0.5:

0.) Go to the AutoUpdate.RootPath in your Windows file browser.
    (Currently: "\\domainserver\data\InformationTechnology\Software Master\Oaklawn\PCW")
1.) Create a new folder whose name is the newest version.
    EXAMPLE: 00090005
2.) Copy the new release .exe into the folder from \bin\Release.
3.) Rename the exe by appending "-" and the newest version number.
    EXAMPLE: PromotionalCreationWizard-00090005.exe
4.) Update the "UpdateFile" with the newest version.
    EXAMPLE: 0.9.0.5
5.) Done! An old, out-of-date copy of PCW will auto-update itself upon first launch.

-------------------------------------------------------------------------------

_*gl hf*_
