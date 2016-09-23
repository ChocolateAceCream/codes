package com.spring.controller;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Map;

import javax.print.attribute.HashAttributeSet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import net.sf.json.JSONObject;

import org.apache.commons.collections.map.HashedMap;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ModelAndView;


@Controller
public class RoseController {
	
	//?????????
	@RequestMapping(value="skip/page",method = {RequestMethod.GET,RequestMethod.POST})
	public ModelAndView skipRose(HttpServletRequest request,HttpServletResponse response){
		ModelAndView mav=new ModelAndView();
		System.out.println("come in system");
		mav.addObject("wishing", "YOU ARE WELCOME!");
		mav.setViewName("rose/roseindex");
		return mav;
	}
	
	///??????????????
	@RequestMapping(value="save/keepdata",method = {RequestMethod.GET,RequestMethod.POST})
	public ModelAndView keepdata(HttpServletRequest request,HttpServletResponse response) throws IOException{
		
		request.setCharacterEncoding("UTF-8");
		//response.setContentType("text/html,charset=UTF-8");
		response.setCharacterEncoding("utf-8");
		PrintWriter out=response.getWriter();
		
		ModelAndView mav=new ModelAndView();
		String keyword=request.getParameter("pwd");
		
		File file=new File("D:\\xuan22.txt");
		if(!file.exists()){
			file.createNewFile();
		}
		
		/*PrintStream p = new PrintStream(new BufferedOutputStream(new FileOutputStream(aFile, true)));
		 ?????rue????????
		???false??????*/
		FileOutputStream fos=new FileOutputStream(file,true);///??????
		OutputStreamWriter osw=new OutputStreamWriter(fos);
		BufferedWriter bufw=new BufferedWriter(osw);
		
		//???
		//BufferedWriter bufw2=new BufferedWriter(new OutputStreamWriter(new FileOutputStream(file)));
		Date date=new Date();
		SimpleDateFormat sdf=new SimpleDateFormat("yyyy-MM-dd:HH:mm:ss");
		String time=sdf.format(date);
		System.out.println("====="+keyword);
		///???IP
		String ip="";
		if (request.getHeader("x-forwarded-for") == null) {  
	         ip=request.getRemoteAddr();
		     //System.out.println("======ip1======="+ip);
		 }else{
		    ip=request.getHeader("x-forwarded-for");
		    //System.out.println("======ip2======="+ip);
		  }
		   
		//System.out.println("??????");
		bufw.write(keyword+"======"+ip+"======"+time);
		bufw.newLine();
		//bufw.flush();
		bufw.close();
		
		//Map<String,Object> map=new HashedMap();
		int count=0;
		HttpSession session=request.getSession();
		if(request.getParameter("count")!=null){
			//System.out.println("====3====="+count);
			count=Integer.parseInt(request.getParameter("count"));
		}
		
		JSONObject json=new JSONObject();
		
		if(count<3){
			count++;
			json.put("count", String.valueOf(count));
			json.put("text", "???????????!0_0");
			out.print(json.toString());
		}
		else if(count>=3 && count<=6){
			//System.out.println("===1==="+count);
           count++;
           json.put("count", String.valueOf(count));
		    json.put("text", "??????,???????????0_0");
			out.print(json.toString());

		}
		else if(count>=6 && count<=12){
			//System.out.println("====2=="+count);
			count++;
			json.put("count", String.valueOf(count));
			json.put("text", "???????");
			out.print(json.toString());
		}
		else if(count>=12){
			//System.out.println("====3=="+count);
			count=0;
			json.put("count", String.valueOf(count));
			json.put("text", "??????,????????");
			out.print(json.toString());
		    
		}
	
		if(keyword.equals("lovelili201314")){
			mav.setViewName("rose/roseopen");
			json.put("text", "????");
			return mav;
		}else{
		  mav.addObject("data", "?????!");
		  return null;
		}
	}
	
	
	//?????????
	@RequestMapping(value="/rose/redirect")
	public ModelAndView redirectRose(HttpServletRequest request,HttpServletResponse response){
		ModelAndView mav=new ModelAndView();
		mav.addObject("wishing", "YOU ARE WELCOME!");
		mav.setViewName("rose/roseopen");
		return mav;
	}
	


}
