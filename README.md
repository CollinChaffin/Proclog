*Proclog*: Proclog monitors and logs which processes are starting and stopping
===================================================================
###### by Collin Chaffin  
[![Twitter Follow](https://img.shields.io/twitter/follow/collinchaffin.svg?style=social)](https://twitter.com/collinchaffin)

[![Development Status](https://img.shields.io/badge/Status-Active-brightgreen.svg)](https://raw.githubusercontent.com/CollinChaffin/Proclog/master/README.md)[![GitHub license](https://img.shields.io/badge/license-Apache%202-blue.svg)](https://raw.githubusercontent.com/CollinChaffin/Proclog/master/LICENSE)[![GitHub stars](https://img.shields.io/github/stars/CollinChaffin/Proclog.svg)](https://github.com/CollinChaffin/Proclog/stargazers)[![GitHub forks](https://img.shields.io/github/forks/CollinChaffin/Proclog.svg)](https://github.com/CollinChaffin/Proclog/network)[![GitHub issues](https://img.shields.io/github/issues/CollinChaffin/Proclog.svg)](https://github.com/CollinChaffin/Proclog/issues)


Description:
------------

Proclog is a console application that monitors processes.  What makes Proclog unique is that as it watches processes as the process list changes it does on-the-fly comparisons to determine and display what is really happening.  

For instance if there are five instances of svchost.exe and one terminated and another spawned all in a matter of seconds, traditionally in task manager you would have to be tracking the PIDs carefully.  

In Proclog, a red line with the name and PID of the ending instance of svchost.exe and another green line of another PID and svchost.exe would be shown to represent this activity.  

I needed this ability to determine what processes were starting and stopping so quickly that my apps were losing focus and troubleshooting with task manager proved to be futile.  




Prerequisites:
--------------

None  




Installation:
-------------

Launch Proclog.exe  




Examples:
---------

Here is an example showing Proclog logging the processes that are quickly stopping and starting:  

![Proclog execution](/images/proclog1.png?raw=true "Proclog execution")  


Dependencies:
-------------

-   None  




TODO:
-------------

  1. Add logging to file  
  
  2. Write windows forms-based GUI
  
  3. Add alerting functions  




LICENSE:
-------------
Please see the included LICENSE file.  
  
_THIS SOFTWARE IS PROVIDED BY THE AUTHOR AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE._  




Patches/Updates/Bugs/Support:
-----------------------------

This code is a work in progress. The interfaces may change without notice.
Updates, bug fixes, and suggestions are welcome, but please be patient.

I have also linked this repository to Slack. Feel free to send a request for an invite to the Slack team for this project.

Please ping me if you have significant changes in mind, before you do what others have done and simply run off with all my code and make a single line mention in their comments and call it their own bear in mind I work hard to write this code and do it for free. I am all for open source collaboration but please give credit where it is due and avoid unnecessary forks instead of simply contributing or discussing ideas here first or hitting me up on Twitter!

Thanks and more to come soon!

__Collin Chaffin__  
[![Twitter Follow](https://img.shields.io/twitter/follow/collinchaffin.svg?style=social)](https://twitter.com/collinchaffin)




Donations:
-----------------------------

You can support my efforts and every donation is greatly appreciated!  
<a href="https://paypal.me/CollinChaffin"><img src="https://www.paypalobjects.com/en_US/i/btn/btn_donate_LG.gif" alt="[paypal]" /></a>  

