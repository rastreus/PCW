ADVICE:
=======
SERIOUSLY READ ALL THE COMMENTS! I tried to keep them updated and informative.
It's a good place to start. But seriously! Send a few days reading the code and
all the comments. Trace the flow. The program starts in the PCW form and goes
from there. **Unfortunately**, there are a lot of features where this software
is tightly coupled to bizarre, hidden ---bug--- _features_ of GPM. If you don't
know what's going on, and you won't (trust me), you'll just have to ask Daniel
or whomever is coding on GPM at the time of reading this.

DESIGN DECISIONS:
=================
There are definitely some "design flaws" in that it is not a nice, arch.
without a lot of tight coupling -- there is quite a bit of tight coupling
unfortunately. Tread carefully lest you break everything. Also, there's not
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
given task at hand. I'm sorry. Just wanted to warn you about that. Also, my
naming convensions weren't that good. I didn't really know what things should
do what and when throughout the process. It was kind of trial-by-fire. Towards
the end, I started using more descriptive names, but until then, it was just
letters -- actually, I started with numbers, but then had to rearrange things
and switched to letters for some reason. I don't know.

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

-------------------------------------------------------------------------------

_*gl hf*_
