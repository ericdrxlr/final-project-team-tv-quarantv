export default function TvShowSelection(tvShow) {
    return `
        <div class="tvShow__grid_container">
            <h2>${tvShow.title}</h2>
            <img class="tvShow__image" src="./img/tvshows/${tvShow.image}" alt="${tvShow.image}"></img>
            <h4>Number of seasons: ${tvShow.season}</h4>
            <h4>Rated: ${tvShow.viewerDiscretion}</h4>
            <input class="tvShow__id" type="hidden" value="${tvShow.id}">

            
            ${tvShow.watchlists.map(value => {
                return `
                <div class="users__specific_user"
                    <h4 class="user__name_btn">Name:   ${value.user.name}</h4>
                    <h4 class="user__name_btn">Status:   ${value.status}</h4>
                    <h4 class="user__name_btn">Rating:   ${value.rating}</h4>
                    <h4 class="user__name_btn">Review:     ${value.review}</h4>
                </div>
               `
        }).join("")}

        </div>

        <section class="comments"> 
        <button class="view-comment__submit">View Comments (Contains Spoilers!)</button>    
        </section> 
        </br>
       
    `
}