using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Анкетирование
{

    public interface view_plus_data
    {//ИНТЕРФЙЕС в кот нужно реализовать отрисовку, на форму
        void draw_row_on(int row, view_table table);//рисование строки
        void remove_row_from(view_table table);//удаление строки
        void resize_Window(view_table table);//изменение окна относительно правого нижнего элемента таблицы
    }

    public class def_cortege: view_plus_data
    {
        int length;
        public ArrayList cols;

        public def_cortege()
        {
            cols = new ArrayList();
        }

        public void draw_row_on(int row, view_table table)
        {//рисование строки
            int i = 0;
            foreach(Control el in cols)
            {
                if(i == 0)
                {
                    el.Top = table.Pos_Y + (row * table.Pos_margin);
                    el.Left = table.Pos_X;
                }
                else
                {
                    Control old = (cols[i - 1] as Control);
                    el.Top = old.Top;
                    el.Left = old.Left + old.Width + table.Pos_margin;
                }
                table.parentForm.Controls.Add(el);
                i++;
            }
            length = i;
        }

        public void remove_row_from(view_table table)
        {//удаление строки
            foreach (Control el in cols)
                table.parentForm.Controls.Remove(el);
        }

        public void resize_Window(view_table table)
        {//изменение окна относительно правого нижнего элемента таблицы
            def_cortege last_row = table.rows[table.lenght_arr - 1] as def_cortege;
            Control last_col = last_row.cols[length - 1] as Control;
            table.parentForm.Width = last_col.Left + last_col.Width + 2 * table.Pos_margin;
            table.parentForm.Height = last_col.Top + last_col.Height + 2 * table.Pos_margin;
        }
    }
    
    public class view_table
    {//КЛАСС ДЛЯ УПРОЩЕНИЯ ОТРИСОВКИ ТАБЛИЦ
        public int Pos_X, Pos_Y, Pos_margin;
        public Form parentForm; int Form_width_old, Form_height_old;
        public ArrayList rows; public int lenght_arr;

        public view_table(int x, int y, int margin, Form parentForm)
        {
            rows = new ArrayList(); lenght_arr = 0;
            Pos_X = x; Pos_Y = y; Pos_margin = margin;
            this.parentForm = parentForm; Form_width_old = parentForm.Width; Form_height_old = parentForm.Height;
        }

        public void add_cortege(view_plus_data obj)
        { rows.Add(obj); lenght_arr++; }

        public void redraw_on_form()
        {
            destroy_table();
            for (int i = 0; i < lenght_arr; i++)
            {
                view_plus_data el = rows[i] as view_plus_data;
                el.draw_row_on(i, this);
                el.resize_Window(this);
            }
        }

        public void destroy_table()
        {
            foreach (view_plus_data el in rows)
                el.remove_row_from(this);
            old_window();
        }

        void old_window()
        { parentForm.Width = Form_width_old; parentForm.Height = Form_height_old; }
    }
}
