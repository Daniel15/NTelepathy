NTelepathy
==========
NTelepathy is C# bindings for the [Telepathy communications framework](http://telepathy.freedesktop.org/).
Basically, it lets you use Telepathy's features from Mono/.NET. 

Currently it only supports updating the status message.

Dependencies
============
 - [dbus-sharp](http://mono.github.com/dbus-sharp/)
   This can be installed on Ubuntu by running `apt-get install libdbus1.0-cil`
   
Compiling
=========

    xbuild NTelepathy.csproj

Licence
=======
This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
