Design Decisions:
I decided to use the DateTimePicker control because it seems nice for users.
It is "idiot-proof." However, the downfall of the DateTimePicker is that it
has to be set to a value. It cannot be a null value. Because of this, all of
the DateTimePickers have been set to DateTime.Today, which is today's date.
That is to say that it is the today that the application is run.

Thinking through this, it means that a promo cannot be created if the date of
the promo is the current date i.e. a promo cannot be sporatically created; it
must be planned and created in advance.

This may never actually become an issue. But if it does, it is possible that
a custom control which inherts from DateTimePicker could be created. I am not
sure about that though.

Be sure to read the comments on Form1.vb if you haven't already done so.
I tried to comment my code accordingly as I was writing it so details and
descriptions should be sprinkled into every file. It shouldn't be too difficult
to understand what's happening.

Version Control:
The application was kept in git version control and pushed to a remote, private
repo hosted on github.com. Cloning (copying the repo with intent to submit
changes back to the original repo) and forking (coping the repo to maintain a
separate version of the software) can both be easily accomplished through git.
Please, please, please take the time to set up your git version control or
some other version control system (subversion, mercurial, bazaar, darcs, etc). 
Being able to roll back to earlier versions of software is invaluable. Even if
you are only a single developer on this project, it is still good practice to
use version control software.

GOOD LUCK, Future Developer!