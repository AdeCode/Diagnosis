var $border_color="#efefef",$grid_color="#ddd",$default_black="#666",$green="#8ecf67",$yellow="#fac567",$orange="#F08C56",$blue="#87ceeb",$red="#f74e4d",$teal="#28D8CA",$grey="#999999",$dark_blue="#0D4F8B";$(function(){var t,e,i,n,a;t=[[1262304e6,192],[12649824e5,320],[12674016e5,1605],[127008e7,1129],[1272672e6,1063],[12753504e5,1105],[12779424e5,2002],[12806208e5,2917],[12832992e5,3100],[12858912e5,1700],[12885696e5,2100],[12911616e5,1700]],e=[[1262304e6,134],[12649824e5,132],[12674016e5,375],[127008e7,553],[1272672e6,275],[12753504e5,979],[12779424e5,789],[12806208e5,1026],[12832992e5,1740],[12858912e5,1882],[12885696e5,2147],[12911616e5,1356]],i=[[1262304e6,232],[12649824e5,487],[12674016e5,623],[127008e7,789],[1272672e6,892],[12753504e5,853],[12779424e5,952],[12806208e5,1245],[12832992e5,1872],[12858912e5,2036],[12885696e5,2345],[12911616e5,1498]],n=[{label:"Likes",data:t},{label:"Shares",data:e},{label:"Tweets",data:i}],a={xaxis:{min:new Date(2009,12,1).getTime(),max:new Date(2010,11,2).getTime(),mode:"time",tickSize:[1,"month"],monthNames:["Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"],tickLength:0},yaxis:{},series:{stack:!0,lines:{show:!0,fill:!0,lineWidth:1},points:{show:!1,radius:4.5,fill:!0,fillColor:"#ffffff",lineWidth:1}},grid:{hoverable:!0,clickable:!1,borderWidth:1,tickColor:$border_color,borderColor:$grid_color},legend:{show:!0},shadowSize:0,tooltip:!0,tooltipOpts:{content:"%s: %y"},colors:[$green,$blue,$yellow,$teal,$yellow,$green]};var s=$("#stacked-area-chart");s.length&&$.plot(s,n,a)});