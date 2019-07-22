function fixage(...args)
{
	for(var i=0;i<args.length;i++)
	{
		if(args[i]<18 || args[i] > 60)
		{
			args.splice(i,1);
			i--;
		}
	}
	if(args.length>0)
		return args.join(",");
	else
		return "NA";
}
